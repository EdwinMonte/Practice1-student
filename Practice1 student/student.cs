using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_student
{
    internal class student : Person
    {
        private string enrollment;
        public string Enrollment { get { return enrollment; } set { enrollment = value; } }

        private string carrer;
        public string Carrer
        {
            get { return carrer; }
            set { carrer = value; }
        }
        private decimal average;
        public decimal Average
        {
            get { return average; }
            set { average = value; }
        }

        public NamePerson Fullname { get; internal set; }

        public override string ToString()
        {
            return "Fullname: " + fullname.ToString() + "\nBirthDate: " + Birthdate.ToString("d") + "\nEnrollment: " + enrollment + "\nCarrer: " + Carrer + "\nAverage: " + Average;
        }
        
         
        
    }
}
