using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class Message
    {
        public int ID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public Message()
        {
            ID = 0;
            SenderID = 3;
            ReceiverID = 2;
            Content = "";
            Timestamp = DateTime.Now;
        }
    }
}
