using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    internal class Maneger
    {
        public string fname;
        public string lname;
        public string birthday;
        public string email;
        public string classs;

        public Maneger(string fname, string lname, string birthday, string email, string classs)
        {
            this.fname = fname;
            this.lname = lname;
            this.birthday = birthday;
            this.email = email;
            this.classs = classs;
        }
    }
}
