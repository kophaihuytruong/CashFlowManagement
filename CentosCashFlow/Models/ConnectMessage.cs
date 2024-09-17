using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class ConnectMessage
    {
        DbContext dbContext = new DbContext();
        public List<Message> getMessagesForUser(int id)
        {
            List<Message> list = new List<Message>();
            string sql = ("SELECT * FROM Messages where " +
                "SenderID = '" + id + "' or " +
                "ReceiverID = '" + id + "' Order by MessageID DESC");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Message emp = new Message();
                emp.ID = int.Parse(rdr.GetValue(0).ToString());
                emp.SenderID = int.Parse(rdr.GetValue(1).ToString());
                emp.ReceiverID = int.Parse(rdr.GetValue(2).ToString());
                emp.Content = rdr.GetValue(3).ToString();
                emp.Timestamp = DateTime.Parse(rdr.GetValue(4).ToString());

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<Message> getAccountMessageForAdminByUserName(string name)
        {
            List<Message> list = new List<Message>();
            string sql = ("SELECT MessageID,SenderID, ReceiverID, Content, Timestamp " +
                "FROM Messages " +
                "JOIN Users ON Messages.SenderID = Users.ID Or Messages.ReceiverID = Users.ID " +
                "where Users.Role = 'User' " +
                "AND Users.Name Like N'%"+ name + "%'" +
                "AND Messages.MessageID = " +
                "(SELECT Top 1 MessageID " +
                "FROM Messages " +
                "where SenderID = Users.ID " +
                "or ReceiverID = Users.ID Order by MessageID DESC) " +
                "Order by MessageID ASC");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Message emp = new Message();
                emp.ID = int.Parse(rdr.GetValue(0).ToString());
                emp.SenderID = int.Parse(rdr.GetValue(1).ToString());
                emp.ReceiverID = int.Parse(rdr.GetValue(2).ToString());
                emp.Content = rdr.GetValue(3).ToString();
                emp.Timestamp = DateTime.Parse(rdr.GetValue(4).ToString());

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<Message> getAccountMessageForAdmin()
        {
            List<Message> list = new List<Message>();
            string sql = ("SELECT MessageID,SenderID, ReceiverID, Content, Timestamp " +
                "FROM Messages " +
                "JOIN Users ON Messages.SenderID = Users.ID Or Messages.ReceiverID = Users.ID " +
                "where Users.Role = 'User' " +
                "AND Messages.MessageID = " +
                "(SELECT Top 1 MessageID " +
                "FROM Messages " +
                "where SenderID = Users.ID " +
                "or ReceiverID = Users.ID Order by MessageID DESC) " +
                "Order by MessageID ASC");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Message emp = new Message();
                emp.ID = int.Parse(rdr.GetValue(0).ToString());
                emp.SenderID = int.Parse(rdr.GetValue(1).ToString());
                emp.ReceiverID = int.Parse(rdr.GetValue(2).ToString());
                emp.Content = rdr.GetValue(3).ToString();
                emp.Timestamp = DateTime.Parse(rdr.GetValue(4).ToString());

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public int addNewMessage(Message message)
        {
            int rs = 0;
            if(message.ReceiverID != 0)
            {
                string sql = "Set dateformat dmy INSERT INTO Messages (SenderID, ReceiverID, Content, Timestamp) " +
                "VALUES ('" + message.SenderID + "', " +
                "'" + message.ReceiverID + "', " +
                "N'" + message.Content + "', " +
                "'" + message.Timestamp + "')";
                rs = dbContext.ExcuteNonQuery(sql);
                dbContext.close();
            }
            else
            {
                Models.ConnectUsers connectUsers = new Models.ConnectUsers();
                List<int> listUser = connectUsers.getListUserID();
                foreach (int id in listUser)
                {
                    string sql = "Set dateformat dmy INSERT INTO Messages (SenderID, ReceiverID, Content, Timestamp) " +
                    "VALUES ('" + message.SenderID + "', " +
                    "'" + id + "', " +
                    "N'" + message.Content + "', " +
                    "'" + message.Timestamp + "')";
                    rs += dbContext.ExcuteNonQuery(sql);
                    dbContext.close();
                }
            }
            return rs;
        }
    }
}
