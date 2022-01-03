using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    internal class Employyes
    {
        public string name;
        public string birthday;
        public string email;
        public int salery;

        public Employyes(string name, string birthday, string email, int salery)
        {
            this.name = name;
            this.birthday = birthday;
            this.email = email;
            this.salery = salery;
        }
       //public void PrintToConsole()
       // {
       //     Console.WriteLine($"{this.name} {this.birthday} {this.email} {this.salery}");
       // }
    }
}
