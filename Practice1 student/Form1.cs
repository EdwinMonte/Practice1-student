namespace Practice1_student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NamePerson fullname = new NamePerson();
            fullname.Name = txtName.Text;
            fullname.Paternlastname = txtPaternlastname.Text;
            fullname.Motherlastname = txtmotherlastname.Text;

            student student = new student();
            student.Fullname = fullname;
            student.Birthdate = dtBirthdate.Value;
            student.Enrollment = txtenrollment.Text;
            student.Average = numericUpDown1.Value;

            lblstudentinfo.Text = student.ToString();
        }
    }
}


