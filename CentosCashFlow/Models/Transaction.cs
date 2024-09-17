using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int UserID { get; set; }
        public string CategoryName { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionDescription { get; set; }
        public string TransactionImg { get; set; }

        public Transaction()
        {
            TransactionID = 0;
            UserID = 0;
            CategoryName = "Thu Nhập";
            TransactionType = "Income";
            Amount= 0;
            TransactionDate = DateTime.Now.Date;
            TransactionDescription = "";
            TransactionImg = "category_df.png";
        }

    }
}
