using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class Category
    {
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryType { get; set; }
        public string CategoryImg { get; set; }

        public Category()
        {
            CategoryID = "None";
            CategoryName= "None";
            CategoryType = "Income";
            CategoryImg = "category_df.png";
        }
    }
}
