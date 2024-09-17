using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosCashFlow.Models
{
    public class ConnectCurrency
    {
        DbContext dbContext = new DbContext();
        public List<Currency> getData()
        {
            List<Currency> list = new List<Currency>();
            string sql = ("Select * from Currency");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Currency emp = new Currency();
                emp.CurrencyCode = rdr.GetValue(0).ToString();
                emp.CurrencyName = rdr.GetValue(1).ToString();
                emp.ExchangeRateUSD = decimal.Parse(rdr.GetValue(2).ToString());

                list.Add(emp);
            }
            dbContext.close();
            return list;
        }
        public List<Currency> getDataByNameOrID(string name)
        {
            List<Currency> list = new List<Currency>();
            string sql = ("Select * from Currency Where Currency_Name Like N'%" + name+ "%' Or Currency_Code Like '%" + name+"%'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Currency emp = new Currency();
                emp.CurrencyCode = rdr.GetValue(0).ToString();
                emp.CurrencyName = rdr.GetValue(1).ToString();
                emp.ExchangeRateUSD = decimal.Parse(rdr.GetValue(2).ToString());

                list.Add(emp);
            }
            dbContext.close();
            return list;
        }
        public int addNewItem(Currency currency)
        {
            int rs = 0;
            string sql = "INSERT INTO Currency VALUES('" + currency.CurrencyCode +
                "', N'" + currency.CurrencyName +
                "', '" + currency.ExchangeRateUSD + "')";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
        public int updateDataForItem(Currency currency)
        {
            int rs = 0;
            string sql = "UPDATE Currency " +
                "SET Currency_Name = N'" + currency.CurrencyName + "', " +
                "ExchangeRateUSD = '" + currency.ExchangeRateUSD + "' " +
                "WHERE Currency_Code = '" + currency.CurrencyCode + "'";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
        public int updateExchangeRateByID(string id, decimal exchangeRate)
        {
            int rs = 0;
            string sql = "UPDATE Currency " +
                "SET ExchangeRateUSD = '" + exchangeRate + "' " +
                "WHERE Currency_Code = '" + id + "'";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
        public int deleteDataById(string id)
        {
            int rs = 0;
            string sql = "EXEC DeleteCurrency '" + id + "'";
            rs = dbContext.ExcuteNonQuery(sql);
            dbContext.close();
            return rs;
        }
    }
}
