using CentosCashFlow.ChildForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class ConnectTransaction
    {
        DbContext dbContext = new DbContext();
        public List<Transaction> getCurrentDataByID(int id)
        {
            List<Transaction> list = new List<Transaction>();
            string sql = ("SELECT " +
                "T.ID AS Transaction_ID, " +
                "T.User_ID, " +
                "C.Category_Name, " +
                "T.Transaction_Type, " +
                "T.Amount, " +
                "T.Transaction_Date, " +
                "T.Transaction_Description, " +
                "C.Category_Img " +
                "FROM Transactions AS T " +
                "JOIN Categories AS C ON T.Category_ID = C.ID " +
                "WHERE T.User_ID = '"+ id +"' " +
                "ORDER BY T.Transaction_Date ASC, Transaction_ID ASC;  ");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Transaction emp = new Transaction();
                emp.TransactionID = int.Parse(rdr.GetValue(0).ToString());
                emp.UserID = int.Parse(rdr.GetValue(1).ToString());
                emp.CategoryName = rdr.GetValue(2).ToString();
                emp.TransactionType = rdr.GetValue(3).ToString();
                emp.Amount = decimal.Parse(rdr.GetValue(4).ToString());
                emp.TransactionDate = DateTime.Parse(rdr.GetValue(5).ToString());
                emp.TransactionDescription = rdr.GetValue(6).ToString();
                emp.TransactionImg = rdr.GetValue(7).ToString();

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<Transaction> getMonthDataByID(int id, int month, int year)
        {
            List<Transaction> list = new List<Transaction>();
            string sql = ("SELECT " +
                "T.ID, " +
                "T.User_ID, " +
                "C.Category_Name, " +
                "T.Transaction_Type, " +
                "T.Amount, " +
                "T.Transaction_Date, " +
                "T.Transaction_Description, " +
                "C.Category_Img " +
                "FROM Transactions T " +
                "JOIN Categories C ON T.Category_ID = C.ID " +
                "WHERE T.User_ID = '" + id + "' AND MONTH(T.Transaction_Date) = '" + month + "' AND YEAR(T.Transaction_Date) = '" + year + "' " +
                "ORDER BY T.Transaction_Date ASC, T.ID ASC;");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Transaction emp = new Transaction();
                emp.TransactionID = int.Parse(rdr.GetValue(0).ToString());
                emp.UserID = int.Parse(rdr.GetValue(1).ToString());
                emp.CategoryName = rdr.GetValue(2).ToString();
                emp.TransactionType = rdr.GetValue(3).ToString();
                emp.Amount = decimal.Parse(rdr.GetValue(4).ToString());
                emp.TransactionDate = DateTime.Parse(rdr.GetValue(5).ToString());
                emp.TransactionDescription = rdr.GetValue(6).ToString();
                emp.TransactionImg = rdr.GetValue(7).ToString();

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public int addNewItem(Transaction transaction)
        {
            Models.ConnectCategory connectCategory = new Models.ConnectCategory();
            Models.Category category = connectCategory.getDataByName(transaction.CategoryName);
            int rs = 0;
            string sql = "Set dateformat dmy INSERT INTO Transactions " +
                "VALUES('" + transaction.UserID + "', '" 
                + category.CategoryID + "', '" 
                + transaction.TransactionType + "', '" 
                + transaction.Amount + "', CONVERT (varchar, '"
                + transaction.TransactionDate + "', 103), N'"
                + transaction.TransactionDescription + "')";

            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
        public int updateDataForItem(Transaction transaction)
        {
            Models.ConnectCategory connectCategory = new Models.ConnectCategory();
            Models.Category category = connectCategory.getDataByName(transaction.CategoryName);
            int rs = 0;
            string sql = "Set dateformat dmy " +
                "EXEC UpdateTransaction " +
                "@TransactionID = '"+ transaction.TransactionID + "', " +
                "@NewAmount = '"+ transaction.Amount + "', " +
                "@NewCategoryID = '"+ category.CategoryID + "', " +
                "@NewTransactionType = '"+ transaction.TransactionType + "', " +
                "@NewTransactionDate = '"+ transaction.TransactionDate + "', " +
                "@NewTransactionDescription = N'"+ transaction.TransactionDescription + "' ";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
        public int deleteDataById(int id)
        {
            int rs = 0;
            string sql = "EXEC DeleteTransaction '" + id+"'";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
    }
}
