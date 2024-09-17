CREATE DATABASE DB_CashFlowManagement;
-- Sử dụng cơ sở dữ liệu QuanLyThuChi
USE DB_CashFlowManagement;
GO
-- Tạo bảng Danh mục (Category)
CREATE TABLE Categories (
    ID CHAR(10) NOT NULL,
    Category_Name NVARCHAR(255) UNIQUE NOT NULL,
	Category_Type CHAR(30) NOT NULL,
	Category_Img CHAR(100) DEFAULT 'category_df.png',
	CONSTRAINT PK_Categories PRIMARY KEY (ID),
	CONSTRAINT CK_Category_Type CHECK (Category_Type IN ('Income', 'Expenditure'))
);
-- Tạo bảng Users (User)
CREATE TABLE Users (
    ID INT IDENTITY(1, 1) NOT NULL,
    Name NVARCHAR(255) NOT NULL,
    Email CHAR(255) UNIQUE,
    Password NVARCHAR(255) NOT NULL,
	Role NVARCHAR(20) DEFAULT N'User',
    Available_Money DECIMAL(18, 2) DEFAULT 0, -- Tiền mặc định = 0 (nếu không nhập)
	Status NVARCHAR(50) DEFAULT'Active',
	CONSTRAINT PK_Users PRIMARY KEY (ID)
);

-- Tạo bảng Giao dịch (Transaction)
CREATE TABLE Transactions (
    ID INT IDENTITY(1, 1) NOT NULL,
    User_ID INT NOT NULL,
    Category_ID CHAR(10) NOT NULL,
    Transaction_Type CHAR(30) NOT NULL,
    Amount DECIMAL(18, 2) NOT NULL,
    Transaction_Date DATE DEFAULT GETDATE(), -- Ngày giao dịch mặc định là ngày hiện tại
    Transaction_Description NVARCHAR(1000) DEFAULT 'Nah', -- Mô tả giao dịch mặc định = Nah

	CONSTRAINT PK_Transactions PRIMARY KEY (ID),
    CONSTRAINT FK_Transactions_Users_ID FOREIGN KEY (User_ID) REFERENCES Users(ID),
    CONSTRAINT FK_Transactions_Category_ID FOREIGN KEY (Category_ID) REFERENCES Categories(ID), 
	CONSTRAINT CHECK_Transactions_Amount CHECK(Amount > 0), -- Lượng tiền chi cho mỗi giao dịch > 0 
	CONSTRAINT CHECK_Transactions_Type CHECK(Transaction_Type IN ('Income', 'Expenditure')), -- Loại giao dịch là Thu hoặc Chi
	CONSTRAINT CHECK_Transaction_Date CHECK (Transaction_Date <= GETDATE()) -- Ngày giao dịch phải là hiện tại hoặc quá khứ
);
CREATE TABLE Languages (
    Language_Code CHAR(2) PRIMARY KEY,
    Language_Name NVARCHAR(255) NOT NULL
);

CREATE TABLE Currency (
    Currency_Code CHAR(3) PRIMARY KEY,
    Currency_Name NVARCHAR(255) NOT NULL,
	ExchangeRateUSD decimal(18, 2) NOT NULL
);
-- Tạo bảng Setting
CREATE TABLE Setting (
	User_ID INT NOT NULL,
    Language_Code CHAR(2) NOT NULL,
    TimeFormat CHAR(10) DEFAULT 'dd/mm/yyyy',
    Currency_Code CHAR(3) NOT NULL,
	OverviewDisplayMode NVARCHAR(100) DEFAULT N'beginning/ending balance',
	CONSTRAINT PK_Setting PRIMARY KEY (User_ID),
	CONSTRAINT FK_Settings_Users_ID FOREIGN KEY (User_ID) REFERENCES Users(ID),
	CONSTRAINT FK_Settings_Users_Currency FOREIGN KEY (Currency_Code) REFERENCES Currency(Currency_Code),
	CONSTRAINT FK_Settings_Users_Language FOREIGN KEY (Language_Code) REFERENCES Languages(Language_Code),
	CONSTRAINT CHK_TimeFormat CHECK (TimeFormat IN ('dd/mm/yyyy', 'mm/dd/yyyy', 'yyyy/mm/dd')),
	CONSTRAINT CHK_OverviewDisplayMode CHECK (OverviewDisplayMode IN (N'beginning/ending balance', N'money in/money out'))
);
CREATE TABLE Messages (
    MessageID INT IDENTITY(1, 1) PRIMARY KEY,
    SenderID INT,
    ReceiverID INT,
    Content NVARCHAR(255),
    Timestamp DATETIME,
	CONSTRAINT FK_Messages_SenderID FOREIGN KEY (SenderID) REFERENCES Users(ID),
	CONSTRAINT FK_Messages_ReceiverID FOREIGN KEY (ReceiverID) REFERENCES Users(ID)
);

Go
--Trigger
GO
CREATE TRIGGER UPDATE_Income_Available_Money
ON Transactions
AFTER INSERT
AS
BEGIN
	IF((SELECT Transaction_Type FROM INSERTED) = 'Income')
		UPDATE Users
		SET Available_Money += (SELECT Amount FROM INSERTED WHERE inserted.User_ID = Users.ID and inserted.Transaction_Type = 'Income') 
		FROM Users
		INNER JOIN inserted ON Users.ID = inserted.User_ID;
END
GO
SELECT T.ID AS Transaction_ID,  
T.User_ID,  C.Category_Name,  T.Transaction_Type,  
T.Amount,  T.Transaction_Date,  T.Transaction_Description,  C.Category_Img 
FROM Transactions AS T 
JOIN Categories AS C ON T.Category_ID = C.ID 
WHERE T.User_ID = 3
ORDER BY T.Transaction_Date ASC, Transaction_ID ASC;  

CREATE TRIGGER UPDATE_Expenditures_Available_Money
ON Transactions
AFTER INSERT
AS
BEGIN
	IF((SELECT Transaction_Type FROM INSERTED) = 'Expenditure')	
		UPDATE Users
		SET Available_Money -= (SELECT Amount FROM INSERTED WHERE inserted.User_ID = Users.ID and inserted.Transaction_Type = 'Expenditure') 
		FROM Users
		INNER JOIN inserted ON Users.ID = inserted.User_ID;
END
GO

CREATE PROCEDURE DeleteCategory
    @Category_ID CHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;

    UPDATE Transactions
    SET Category_ID = 
        CASE
            WHEN Transaction_Type = 'Income' THEN 'TKK'
            WHEN Transaction_Type = 'Expenditure' THEN 'CKK'
            ELSE Category_ID
        END
    WHERE Category_ID = @Category_ID;

    -- Xoá danh mục
    DELETE FROM Categories
    WHERE ID = @Category_ID;

    COMMIT; -- Kết thúc giao dịch
END;
GO
--
CREATE PROCEDURE DeleteTransaction
    @TransactionID INT
AS
BEGIN
    DECLARE @TransactionAmount DECIMAL(18, 2);
    DECLARE @TransactionType CHAR(30);

    -- Lấy Transaction Amount và Transaction Type từ Transactions
    SELECT @TransactionAmount = Amount, @TransactionType = Transaction_Type
    FROM Transactions
    WHERE ID = @TransactionID;

    -- Cộng hoặc trừ Amount vào Available_Money dựa vào Transaction_Type
    UPDATE U
    SET U.Available_Money = 
        CASE 
            WHEN @TransactionType = 'Income' THEN U.Available_Money + @TransactionAmount
            WHEN @TransactionType = 'Expenditure' THEN U.Available_Money - @TransactionAmount
            ELSE U.Available_Money
        END
    FROM Users U
    WHERE U.ID = (SELECT User_ID FROM Transactions WHERE ID = @TransactionID);

    -- Xoá Transaction
    DELETE FROM Transactions
    WHERE ID = @TransactionID;
END
GO
--
CREATE PROCEDURE UpdateTransaction
    @TransactionID INT,
    @NewAmount DECIMAL(18, 2),
    @NewCategoryID CHAR(10),
    @NewTransactionType CHAR(30),
    @NewTransactionDate DATE,
    @NewTransactionDescription NVARCHAR(1000)
AS
BEGIN
    DECLARE @OldTransactionType CHAR(30);
	DECLARE @OldAmount DECIMAL(18, 2);
	DECLARE @UserID INT;
    -- Lấy thông tin giao dịch hiện tại
    SELECT @OldTransactionType = Transaction_Type, @OldAmount = Amount, @UserID = User_ID
    FROM Transactions
    WHERE ID = @TransactionID;
    -- 
    IF @OldTransactionType != @NewTransactionType AND @OldTransactionType = 'Expenditure' AND @NewTransactionType = 'Income'
    BEGIN
        UPDATE Users
        SET Available_Money = Available_Money + @OldAmount + @NewAmount
        WHERE ID = @UserID;
    END
	ELSE IF @OldTransactionType != @NewTransactionType AND @OldTransactionType = 'Income' AND @NewTransactionType = 'Expenditure'
    BEGIN
        UPDATE Users
        SET Available_Money = Available_Money - @OldAmount - @NewAmount
        WHERE ID = @UserID;
    END
	ELSE 
	
	IF @OldTransactionType = @NewTransactionType
    BEGIN
		IF @OldTransactionType = 'Income'
		BEGIN
			UPDATE Users
			SET Available_Money = Available_Money - (@OldAmount - @NewAmount)
			WHERE ID = @UserID;
		END
		IF @NewTransactionType = 'Expenditure'
		BEGIN
			UPDATE Users
			SET Available_Money = Available_Money + (@OldAmount - @NewAmount)
			WHERE ID = @UserID;
		END
    END
	-- Cập nhật giao dịch
    UPDATE Transactions
    SET Amount = @NewAmount,
        Transaction_Type = @NewTransactionType,
        Transaction_Date = @NewTransactionDate,
        Transaction_Description = @NewTransactionDescription,
		Category_ID = @NewCategoryID
    WHERE ID = @TransactionID;
END
GO
--
CREATE PROCEDURE UpdateUser
    @UserID INT,
    @NewName NVARCHAR(255) = NULL,
    @NewEmail CHAR(255) = NULL,
    @NewPassword NVARCHAR(255) = NULL,
    @NewRole NVARCHAR(20) = NULL,
    @NewAvailableMoney DECIMAL(18, 2) = NULL
AS
BEGIN
    UPDATE Users
    SET 
        Name = ISNULL(@NewName, Name),
        Email = ISNULL(@NewEmail, Email),
        Password = ISNULL(@NewPassword, Password),
        Role = ISNULL(@NewRole, Role),
        Available_Money = ISNULL(@NewAvailableMoney, Available_Money)
    WHERE ID = @UserID;
END
GO
--
CREATE PROCEDURE deleteUser
    @UserID INT
AS
BEGIN
    DELETE FROM Transactions
    WHERE User_ID = @UserID;

	DELETE FROM Setting
    WHERE User_ID = @UserID;

    -- Xóa user từ bảng Users
    DELETE FROM Users
    WHERE ID = @UserID;
END
GO
--
CREATE PROCEDURE InsertUser
@name NVARCHAR(255),@email CHAR(255),@password NVARCHAR(255), @role NVARCHAR(20)
AS
BEGIN
	INSERT INTO Users(Name,Email,Password, Role)
	VALUES(@name,@email,@password, @role);
	DECLARE @id INT;
	SET @id = (SELECT ID FROM Users WHERE Name = @name)
	INSERT INTO Setting(User_ID, Language_Code, Currency_Code)
	VALUES (@id, 'EN', 'VND')
	END
GO

--
CREATE PROCEDURE DeleteLanguage
    @language_code CHAR(2)
AS
BEGIN
    DECLARE @new_language_code CHAR(2);

    SELECT TOP 1 @new_language_code = Language_Code
    FROM Languages
	WHERE Language_Code <> @language_code;

    UPDATE Setting
    SET Language_Code = @new_language_code
    WHERE Language_Code = @language_code;

    DELETE FROM Languages
    WHERE Language_Code = @language_code;
END;
GO
--
CREATE PROCEDURE DeleteCurrency
    @currency_code CHAR(3)
AS
BEGIN
    DECLARE @new_currency_code CHAR(3);

    SELECT TOP 1 @new_currency_code = Currency_Code
    FROM Currency
	WHERE Currency_Code <> @currency_code;

    UPDATE Setting
    SET Currency_Code = @new_currency_code
    WHERE Currency_Code = @currency_code;

    DELETE FROM Currency
    WHERE Currency_Code = @currency_code;
END;
GO
CREATE PROCEDURE DisableUser
    @UserID INT
AS
BEGIN
    UPDATE Users 
	SET Status = 'Disable'
	WHERE ID = @UserID ;
END
GO
CREATE PROCEDURE UnlockUser
    @UserID INT
AS
BEGIN
    UPDATE Users 
	SET Status = 'Active'
	WHERE ID = @UserID ;
END
GO
--
INSERT INTO Languages
VALUES ('EN', N'English'),
('VN', N'Vietnamese')
--
INSERT INTO Currency
VALUES ('USD', N'United State Dollar', 1),
('VND', N'Việt Nam Đồng', 23585)

--
INSERT INTO Categories(ID, Category_Name, Category_Type)
VALUES('CTP',N'Food', 'Expenditure'),
('CSH',N'Lifestyle Expenses', 'Expenditure'),
('CTD',N'Electricity Bill', 'Expenditure'),
('CTN',N'Water Bill', 'Expenditure'),
('CTT',N'Rental Fee', 'Expenditure'),
('TTN',N'Salary', 'Income'),
('CTH',N'Tuition Fee', 'Expenditure'),
('TKK',N'Other Income', 'Income'),
('CKK',N'Other Expenses', 'Expenditure');

INSERT INTO Users(Name,Email,Password,Role)
VALUES(N'Nguyễn Huy Hoàng',N'Hoang012@gmail.com',N'admin',N'Admin'),
(N'Nguyễn Minh Thư',N'Thu2123@gmail.com',N'admin',N'Admin');
INSERT INTO Users(Name,Email,Password)
VALUES(N'Trương Quốc Huy',N'Huy5512@gmail.com',N'Huy12445'),
(N'Vương Kim Dinh',N'Dinh0201@gmail.com',N'Din4124'),
(N'Trương Thế Vinh',N'Vinh0111@gmail.com',N'Vinh2217');

--
INSERT INTO Setting(User_ID, Language_Code, Currency_Code)
VALUES (3, 'VN', 'VND'),
(2, 'EN', 'USD')


INSERT INTO Transactions
VALUES(1,'TTN','Income',1000000,'2023/8/10',N'Lương Tháng 8');
INSERT INTO Transactions
VALUES(3,'TTN','Income',150000,'2023/8/19',N'Lương Tháng 8');
INSERT INTO Transactions
VALUES(2,'TKK','Income',3000000,'2023/9/1',N'Mẹ Gửi');
INSERT INTO Transactions
VALUES(1,'CTT','Expenditure',500000,GETDATE(),N'Đóng Trọ Tháng 9');
INSERT INTO Transactions
VALUES(3,'CTP','Expenditure',15000,'2023/9/1',N'Mua Đồ ăn');
INSERT INTO Transactions
VALUES(2,'CTD','Expenditure',200000,GETDATE(),N'Điện Tháng 8');

INSERT INTO Messages (SenderID, ReceiverID, Content, Timestamp)
VALUES
	(4, 2, N'Xin chào. Tôi cần hổ trợ', '2023-11-28 12:00:00'),
	(2, 4, N'Chào bạn. Bạn cần tôi tư vấn điều gì?', '2023-11-28 13:00:00'),
	(4, 2, N'Tôi muốn đổi mật khẩu thì vào đâu?', '2023-11-28 14:00:00');

INSERT INTO Transactions
VALUES(3,'TTN','Income',10000000,'2023/10/1',N'Lương Tháng 9');
INSERT INTO Transactions
VALUES(3,'CTP','Expenditure',275000,'2023/10/1',N'Chợ');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',5000,'2023/10/1',N'cho con đi học');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',50000,'2023/10/1',N'Xăng');
INSERT INTO Transactions
VALUES(3,'CTP','Expenditure',200000,'2023/10/2',N'Chợ');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',50000,'2023/10/3',N'Xăng');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',5000,'2023/10/3',N'cho con đi học');
INSERT INTO Transactions
VALUES(3,'CTT','Expenditure',3500000,'2023/10/4',N'Tiền nhà tháng 9');
INSERT INTO Transactions
VALUES(3,'CTH','Expenditure',3000000,'2023/10/5',N'Tiền học cho con');
INSERT INTO Transactions
VALUES(3,'CTP','Expenditure',250000,'2023/10/5',N'Chợ');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',5000,'2023/10/5',N'cho con đi học');
INSERT INTO Transactions
VALUES(3,'CTD','Expenditure',200000,'2023/10/6',N'Điện Tháng 9');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',50000,'2023/10/6',N'Xăng');
INSERT INTO Transactions
VALUES(3,'CTN','Expenditure',200000,'2023/10/7',N'Nước Tháng 9');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',5000,'2023/10/7',N'cho con đi học');
INSERT INTO Transactions
VALUES(3,'CTP','Expenditure',325000,'2023/10/7',N'Chợ');
INSERT INTO Transactions
VALUES(3,'TTN','Income',15000000,'2023/10/8',N'Lương Tháng 9 chồng');
INSERT INTO Transactions
VALUES(3,'CSH','Expenditure',1000000,'2023/10/8',NULL);
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',50000,'2023/10/9',N'Xăng');
GO
INSERT INTO Transactions
VALUES(3,'CTP','Expenditure',350000,'2023/11/1',N'Chợ');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',6000,'2023/11/1',N'cho con đi học');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',60000,'2023/11/1',N'Xăng');
INSERT INTO Transactions
VALUES(3,'CTP','Expenditure',250000,'2023/11/2',N'Chợ');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',60000,'2023/11/3',N'Xăng');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',5000,'2023/11/3',N'cho con đi học');
INSERT INTO Transactions
VALUES(3,'CTT','Expenditure',3500000,'2023/11/4',N'Tiền nhà tháng 10');
INSERT INTO Transactions
VALUES(3,'CTH','Expenditure',3500000,'2023/11/5',N'Tiền học cho con');
INSERT INTO Transactions
VALUES(3,'CTP','Expenditure',275000,'2023/11/5',N'Chợ');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',7000,'2023/11/5',N'cho con đi học');
INSERT INTO Transactions
VALUES(3,'CTD','Expenditure',300000,'2023/11/6',N'Điện Tháng 10');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',50000,'2023/11/6',N'Xăng');
INSERT INTO Transactions
VALUES(3,'CTN','Expenditure',235000,'2023/11/7',N'Nước Tháng 10');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',6000,'2023/11/7',N'cho con đi học');
INSERT INTO Transactions
VALUES(3,'CTP','Expenditure',385000,'2023/11/7',N'Chợ');
INSERT INTO Transactions
VALUES(3,'TTN','Income',17000000,'2023/11/8',N'Lương Tháng 10 chồng');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',50000,'2023/11/9',N'Xăng');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',5000,'2023/11/11',N'cho con đi học');
INSERT INTO Transactions
VALUES(3,'CTP','Expenditure',355000,'2023/11/11',N'Chợ');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',60000,'2023/11/11',N'Xăng');
INSERT INTO Transactions
VALUES(3,'CKK','Expenditure',7000,'2023/11/11',N'cho con đi học');
INSERT INTO Messages (SenderID, ReceiverID, Content, Timestamp)
VALUES
    (3, 2, N'Xin chào. Tôi cần hổ trợ', '2023-11-28 12:00:00'),
    (2, 3, N'Chào bạn. Bạn cần tôi tư vấn điều gì?', '2023-11-28 12:02:00'),
    (3, 2, N'Tôi muốn thêm một danh mục mới thì sao?', '2023-11-28 13:01:01'),
	(2, 3, N'Bạn cần thêm danh mục gì? Chúng tôi sẽ hỗ trợ bạn.', '2023-11-28 13:06:01');
SELECT * FROM Messages where SenderID =3 or ReceiverID =3 Order by MessageID ASC

SELECT MessageID, SenderID, ReceiverID, Content, Timestamp
FROM Messages
JOIN Users ON Messages.SenderID = Users.ID Or Messages.ReceiverID = Users.ID
where Users.Role = 'User'
AND Messages.MessageID = (SELECT Top 1 MessageID FROM Messages where SenderID = Users.ID or ReceiverID = Users.ID Order by MessageID DESC)
Order by MessageID DESC

SELECT MessageID, SenderID, ReceiverID, Content, Timestamp
FROM Messages
JOIN Users ON Messages.SenderID = Users.ID Or Messages.ReceiverID = Users.ID
where Users.Role = 'User'
AND Users.Name Like N'%h%'
AND Messages.MessageID = (SELECT Top 1 MessageID FROM Messages where SenderID = Users.ID or ReceiverID = Users.ID Order by MessageID DESC)
Order by MessageID DESC

SELECT ID FROM Users WHERE Role = 'User'

SELECT ID, Name, Email FROM Users WHERE Role = 'User'
Alter table Transactions
Add TransactionImg Nvarchar(50)
SELECT* FROM Users
SELECT* FROM Setting
SELECT* FROM Categories
SELECT* FROM Transactions
SELECT* FROM Languages
SELECT* FROM Currency

Update Setting
Set 
Language_Code = 'EN',
Currency_Code = 'VND',
TimeFormat = 'dd/mm/yyyy',
OverviewDisplayMode = N'beginning/ending balance' 
Where User_ID = 3

--EXEC DeleteCategory @Category_ID = 'CTP';

EXEC DeleteTransaction 42;

--EXEC UpdateTransaction @TransactionID = 22,
--    @NewAmount = 2000000,
--    @NewCategoryID = 'CKK',
--    @NewTransactionType = 'Expenditure',
--    @NewTransactionDate = '2023/08/10',
--    @NewTransactionDescription = 'Chi' 

--EXEC DeleteLanguage 'EN'
--EXEC DeleteCurrency 'USD'
--update Setting 
--Set Language_Code = 'EN'
--Where User_ID = 1

--update Setting 
--Set Currency_Code = 'USD'
--Where User_ID = 2


--Drop table Transactions
--Drop table Categories
--Drop table Setting
--Drop table Users
--Drop table Currency

--SELECT T.ID, T.User_ID, C.Category_Name AS Category_Name, T.Transaction_Type, T.Amount, T.Transaction_Date, T.Transaction_Description, C.Category_Img 
--FROM Transactions T
--JOIN Categories C ON T.Category_ID = C.ID
--WHERE T.User_ID = 3
--AND MONTH(T.Transaction_Date) = 9 AND YEAR(T.Transaction_Date) = 2023
--ORDER BY T.Transaction_Date ASC;	

--SELECT t.ID, c.Category_Img, c.Category_Name, t.Amount, t.Transaction_Date, t.Transaction_Description, t.Transaction_Type
--FROM Categories AS c
--JOIN Transactions AS t ON c.ID = t.Category_ID
--WHERE c.Category_Name = N'Thu Nhập'
--    AND YEAR(t.Transaction_Date) = 2023
--    AND MONTH(t.Transaction_Date) = 11
--	AND t.User_ID = 3
--ORDER BY t.Transaction_Date DESC;