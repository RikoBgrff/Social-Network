using Social_Network.AdminNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Social_Network.PostNamespace;
using System.Windows.Forms;

namespace Social_Network
{

    class Instance
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
    class Program
    {
        Admin admin = new Admin()

        {
            Email = "riko.bagirli777@gmail.com",
            Username = "rikobgrff",
            Password = "ejdaha",
        };
         
        static void Main(string[] args)
        {
            SystemManagement systemManagement = new SystemManagement();
            systemManagement.Login();


        }
    }
}
