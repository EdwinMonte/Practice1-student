using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_student
{
    internal class NamePerson
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        private string paternlastname;
        public string Paternlastname
        {
            get { return paternlastname; }
            set { paternlastname = value; }
        }
        private string motherlastname;
        public string Motherlastname
        {
            get { return motherlastname; }
            set { motherlastname = value; }
        }

        public NamePerson()
        {
            name = " ";
            paternlastname = " ";
            motherlastname = " ";
        }

        public override string ToString()
        {
            return name + " " + paternlastname + " " + motherlastname;
        }
        
        
    }
}



