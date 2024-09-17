using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class Settings
    {
        public int UserID { get; set; }
        public string LanguageCode { get; set; }
        public string TimeFormat { get; set; }
        public string CurrencyCode { get; set; }
        public string OverviewDisplayMode { get; set; }

        public Settings() {
            UserID = 1;
            LanguageCode = "en";
            TimeFormat = "dd/mm/yyyy";
            CurrencyCode = "USD";
            OverviewDisplayMode = "beginning/ending balance";
        }
    }
}
