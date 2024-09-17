using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using CentosCashFlow.ChildForms;

namespace CentosCashFlow.Models
{

    public class ConnectCategory
    {
        DbContext dbContext = new DbContext();
        public List<Category> getIncomeTypeData()
        {
         
            List<Category> list = new List<Category>();
            string sql = ("Select * from Categories where Category_Type = 'Income'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Category emp = new Category();
                emp.CategoryID = rdr.GetValue(0).ToString();
                emp.CategoryName = rdr.GetValue(1).ToString();
                emp.CategoryType = rdr.GetValue(2).ToString();
                emp.CategoryImg = rdr.GetValue(3).ToString();

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public List<Category> getExpenditureTypeData()
        {
            List<Category> list = new List<Category>();
            string sql = ("Select * from Categories where Category_Type = 'Expenditure'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Category emp = new Category();
                emp.CategoryID = rdr.GetValue(0).ToString();
                emp.CategoryName = rdr.GetValue(1).ToString();
                emp.CategoryType = rdr.GetValue(2).ToString();
                emp.CategoryImg = rdr.GetValue(3).ToString();

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public Category getDataByID(string id)
        {
            Category emp = new Category();
            string sql = ("Select * from Categories where ID = '"+id+"'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                emp.CategoryID = rdr.GetValue(0).ToString();
                emp.CategoryName = rdr.GetValue(1).ToString();
                emp.CategoryType = rdr.GetValue(2).ToString();
                emp.CategoryImg = rdr.GetValue(3).ToString();

            }
            rdr.Close();
            return emp;
        }
        public Category getDataByName(string name)
        {
            Category emp = new Category();
            string sql = ("Select * from Categories where Category_Name = N'"+name+"'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                emp.CategoryID = rdr.GetValue(0).ToString();
                emp.CategoryName = rdr.GetValue(1).ToString();
                emp.CategoryType = rdr.GetValue(2).ToString();
                emp.CategoryImg = rdr.GetValue(3).ToString();
            }
            rdr.Close();
            return emp;
        }
        public int addNewItem(Category category)
        {
            int rs = 0;
            string sql = "INSERT INTO Categories VALUES('" + category.CategoryID+
                "', N'" + category.CategoryName +
                "', '" + category.CategoryType + "', '" + category.CategoryImg + "')";
            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }
        public int updateDataForItem(Category category)
        {
            int rs = 0;
            string sql = "UPDATE Categories " +
                "SET Category_Type = '" + category.CategoryType + "', " +
                "Category_Name = N'" + category.CategoryName + "', " +
                "Category_Img = '" + category.CategoryImg + "' " +
                "WHERE ID = '" + category.CategoryID + "'";
            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }

        public int deleteDataById(string id)
        {
            int rs = 0;
            string sql = "EXEC DeleteCategory @Category_ID = '"+id+"'";
            rs = dbContext.ExcuteNonQuery(sql);
            return rs;
        }
    }
}
