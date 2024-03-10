using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_student
{
    internal class Person
    {
        protected DateTime birthdate;
        public DateTime Birthdate
        {
            get { return birthdate; }
            set
            {
                birthdate = value;
            }
        }
        protected NamePerson fullname
        {
            get{ return fullname; }
            set { fullname = value; }
        }
        public Person()
        {
            birthdate = DateTime.MinValue;
            fullname = new NamePerson();
        }
        public override string ToString()
        {
            return fullname.ToString()+ " "+birthdate.Date;
        }
        
            
        
    }
}
