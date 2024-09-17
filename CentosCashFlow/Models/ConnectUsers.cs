using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class ConnectUsers
    {
        DbContext dbContext = new DbContext();
        
        public List<int> getListUserID()
        {
            List<int> list = new List<int>();
            string sql = ("SELECT ID FROM Users WHERE Role = 'User'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                int emp = 0;
                emp = int.Parse(rdr.GetValue(0).ToString());

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<UserAccountInfo> getUserAccountsInfo()
        {
            List<UserAccountInfo> list = new List<UserAccountInfo>();
            string sql = ("SELECT ID, Name, Email FROM Users WHERE Role = 'User'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                UserAccountInfo emp = new UserAccountInfo();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.UserName = rdr.GetValue(1).ToString();
                emp.Email = rdr.GetValue(2).ToString().Trim();

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<UserAccountInfo> getUserAccountsFullInfo()
        {
            List<UserAccountInfo> list = new List<UserAccountInfo>();
            string sql = ("SELECT ID, Name, Email,Status FROM Users WHERE Role = 'User'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                UserAccountInfo emp = new UserAccountInfo();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.UserName = rdr.GetValue(1).ToString();
                emp.Email = rdr.GetValue(2).ToString().Trim();
                emp.Status = rdr.GetValue(3).ToString();
                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<UserAccountInfo> getUserAccountsInfoByName(string name)
        {
            List<UserAccountInfo> list = new List<UserAccountInfo>();
            string sql = ("SELECT ID, Name, Email FROM Users WHERE Role = 'User' And Name Like N'%" + name+"%'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                UserAccountInfo emp = new UserAccountInfo();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.UserName = rdr.GetValue(1).ToString();
                emp.Email = rdr.GetValue(2).ToString().Trim();
                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<UserAccountInfo> getUserAccountsFullInfoByName(string name)
        {
            List<UserAccountInfo> list = new List<UserAccountInfo>();
            string sql = ("SELECT ID, Name, Email,Status FROM Users WHERE Role = 'User' And Name Like N'%" + name + "%'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                UserAccountInfo emp = new UserAccountInfo();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.UserName = rdr.GetValue(1).ToString();
                emp.Email = rdr.GetValue(2).ToString().Trim();
                emp.Status = rdr.GetValue(3).ToString();
                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<UserAccountInfo> getAdminAccountsInfo()
        {
            List<UserAccountInfo> list = new List<UserAccountInfo>();
            string sql = ("SELECT ID, Name, Email FROM Users WHERE Role = 'Admin'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                UserAccountInfo emp = new UserAccountInfo();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.UserName = rdr.GetValue(1).ToString();
                emp.Email = rdr.GetValue(2).ToString().Trim();

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<UserAccountInfo> getAdminAccountsFullInfo()
        {
            List<UserAccountInfo> list = new List<UserAccountInfo>();
            string sql = ("SELECT ID, Name, Email,Status FROM Users WHERE Role = 'Admin'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                UserAccountInfo emp = new UserAccountInfo();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.UserName = rdr.GetValue(1).ToString();
                emp.Email = rdr.GetValue(2).ToString().Trim();
                emp.Status = rdr.GetValue(3).ToString();
                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<UserAccountInfo> getAdminAccountsInfoByName(string name)
        {
            List<UserAccountInfo> list = new List<UserAccountInfo>();
            string sql = ("SELECT ID, Name, Email FROM Users WHERE Role = 'Admin' And Name Like N'%" + name + "%'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                UserAccountInfo emp = new UserAccountInfo();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.UserName = rdr.GetValue(1).ToString();
                emp.Email = rdr.GetValue(2).ToString().Trim();

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<UserAccountInfo> getAdminAccountsFullInfoByName(string name)
        {
            List<UserAccountInfo> list = new List<UserAccountInfo>();
            string sql = ("SELECT ID, Name, Email,Status FROM Users WHERE Role = 'Admin' And Name Like N'%" + name + "%'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                UserAccountInfo emp = new UserAccountInfo();
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.UserName = rdr.GetValue(1).ToString();
                emp.Email = rdr.GetValue(2).ToString().Trim();
                emp.Status = rdr.GetValue(3).ToString();
                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public int updateUserAccountInfo(UserAccountInfo user)
        {
            int rs = 0;
            string sql = "EXEC UpdateUser " +
                "@UserID = '" + user.Id + "', " +
                "@NewName = N'" + user.UserName + "', " +
                "@NewEmail = '" + user.Email + "' ";

            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }
        public string getUserNameByID(int id)
        {
            string emp = "";
            string sql = ("SELECT Name FROM Users WHERE ID = '" + id + "'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                emp = rdr.GetValue(0).ToString();
            }
            rdr.Close();
            return emp;
        }
        public bool isAdmin(int id)
        {
            string emp = "";
            string sql = ("SELECT Role FROM Users WHERE ID = '" + id + "'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                emp = rdr.GetValue(0).ToString();
            }
            rdr.Close();
            return emp == "Admin";
        }
        public User getUserDataByID(int id)
        {
            User emp = new User();
            string sql = ("SELECT " +
                "U.ID, " +
                "U.Name, " +
                "U.Email, " +
                "U.Password, " +
                "U.Role, " +
                "U.Available_Money, " +
                "S.Language_Code, " +
                "S.TimeFormat, " +
                "S.Currency_Code, " +
                "S.OverviewDisplayMode " +
                "FROM Users U " +
                "INNER JOIN Setting S ON U.ID = S.User_ID " +
                "WHERE U.ID = '" + id+ "';");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if(rdr.Read())
            {
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                emp.Email = rdr.GetValue(2).ToString().Trim();
                emp.Password = rdr.GetValue(3).ToString();
                emp.Role = rdr.GetValue(4).ToString();
                emp.AvailableMoney = decimal.Parse(rdr.GetValue(5).ToString());
                emp.UserSettings.UserID = emp.Id;
                emp.UserSettings.LanguageCode = rdr.GetValue(6).ToString();
                emp.UserSettings.TimeFormat = rdr.GetValue(7).ToString();
                emp.UserSettings.CurrencyCode = rdr.GetValue(8).ToString();
                emp.UserSettings.OverviewDisplayMode = rdr.GetValue(9).ToString();

            }

            return emp;
        }
        public string getUserPasswordByID(int id)
        {
            string emp = "";
            string sql = ("SELECT Password FROM Users WHERE ID = '" + id + "';");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                emp = rdr.GetValue(0).ToString().Trim();
            }

            return emp;
        }
        public User Login(string email, string password)
        {
            ConnectPassword connectPassword = new ConnectPassword();
            string sql = ("SELECT ID,Status FROM Users WHERE Email = '" + email + "' and Password = '"+ Models.ConnectPassword.Create_MD5(password) + "'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                int id = int.Parse(rdr.GetValue(0).ToString());
                string Status = rdr.GetValue(1).ToString();
                if(Status == "Disable")
                {
                    return null;
                }
                rdr.Close();
                return getUserDataByID(id);
            }
            return null;
        }

        public Settings getUserSettingsByID(int id)
        {

            Settings emp = new Settings();
            string sql = ("SELECT * FROM Setting WHERE User_ID = '"+id+"'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                emp.UserID = int.Parse(rdr.GetValue(0).ToString());
                emp.LanguageCode = rdr.GetValue(1).ToString();
                emp.TimeFormat = rdr.GetValue(2).ToString();
                emp.CurrencyCode = rdr.GetValue(3).ToString();
                emp.OverviewDisplayMode = rdr.GetValue(4).ToString();
            }
            rdr.Close();
            return emp;
        }

        public int updateInfoFor(User user)
        {
            int rs = 0;
            string sql = "EXEC UpdateUser " +
                "@UserID = '"+ user.Id + "', " +
                "@NewName = N'"+ user.Name + "', " +
                "@NewEmail = '"+ user.Email + "', " +
                "@NewAvailableMoney = '"+ user.AvailableMoney + "'";

            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }
        public int updateUserSettingsFor(Models.Settings userSettings)
        {
            int rs = 0;
            string sql = "Update Setting Set " +
                "Language_Code = '" + userSettings.LanguageCode + "', " +
                "Currency_Code = '" + userSettings.CurrencyCode + "', " +
                "TimeFormat = '" + userSettings.TimeFormat + "', " +
                "OverviewDisplayMode = N'" + userSettings.OverviewDisplayMode + "' " +
                "Where User_ID = '" + userSettings.UserID + "'";

            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }
        public int updatePasswordFor(User user)
        {
            int rs = 0;
            string sql = "EXEC UpdateUser " +
                "@UserID = '"+ user.Id + "', " +
                "@NewPassword = '"+ user.Password + "'";
            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }
        public int deleteAccountByID(int id) {
            int rs = 0;
            string sql = "EXEC deleteUser '" + id + "'";

            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }
        public int disableAccountByID(int id)
        {
            int rs = 0;
            string sql = "EXEC disableUser '" + id + "'";

            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }
        public int UnlockAccountByID(int id)
        {
            int rs = 0;
            string sql = "EXEC UnlockUser '" + id + "'";

            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }
        public int Register(string name, string email, string password)
        {
            string hashPass = Models.ConnectPassword.Create_MD5(password);
            int rs = 0;
            string sql = "EXEC InsertUser " +
               "@name = N'" + name + "', " +
               "@email = N'" + email + "', " +
               "@password = N'" + hashPass + "'," +
               "@role = N'User'";

            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }
    }
}
