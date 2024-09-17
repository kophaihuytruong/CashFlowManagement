using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class ConnectLanguage
    {
        DbContext dbContext = new DbContext();
        public List<Language> getData()
        {
            List<Language> list = new List<Language>();
            string sql = ("Select * from Languages");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Language emp = new Language();
                emp.Language_Code = rdr.GetValue(0).ToString();
                emp.Language_Name = rdr.GetValue(1).ToString();

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<Language> getDataByNameOrID(string name)
        {
            List<Language> list = new List<Language>();
            string sql = ("Select * from Languages Where Language_Name Like N'%"+name+"%' Or Language_Code Like '%"+name+"%'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Language emp = new Language();
                emp.Language_Code = rdr.GetValue(0).ToString();
                emp.Language_Name = rdr.GetValue(1).ToString();

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public Language getDataByID(string id)
        {
            Language emp = new Language();
            string sql = ("Select * from Languages where Language_Code = '"+id+"'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                emp.Language_Code = rdr.GetValue(0).ToString();
                emp.Language_Name = rdr.GetValue(1).ToString();
            }
            rdr.Close();
            return emp;
        }
        public Language getDataByName(string name)
        {
            Language emp = new Language();
            string sql = ("Select * from Languages where Language_Name = '" + name + "'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                emp.Language_Code = rdr.GetValue(0).ToString();
                emp.Language_Name = rdr.GetValue(1).ToString();
            }
            rdr.Close();
            return emp;
        }

        public int addNewItem(Language language)
        {
            int rs = 0;
            string sql = "INSERT INTO Languages VALUES('" + language.Language_Code +
                "', N'" + language.Language_Name + "')";
            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }
        public int updateDataForItem(Language language)
        {
            int rs = 0;
            string sql = "UPDATE Languages " +
                "SET Language_Name = N'" + language.Language_Name + "' " +
                "WHERE Language_Code = '" + language.Language_Code + "'";
            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }
        public int deleteDataById(string id)
        {
            int rs = 0;
            string sql = "EXEC DeleteLanguage '" + id + "'";
            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }
    }
}
