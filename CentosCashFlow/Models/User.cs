using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public decimal AvailableMoney { get; set; }

        public Settings UserSettings { get; set; }

        public User()
        {
            Id = 0;
            Name = "";
            Password = "";
            Email = "example@gmail.com";
            Role = "User";
            AvailableMoney = 0;
            UserSettings = new Settings();
        }
    }
}
