namespace LAB04
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        double maxGrade = 0;
        double minGrade = int.MaxValue;
        double AvgGPA = 0;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = this.textBoxName.Text;
            int year = int.Parse(this.textBoxbYear.Text);
            double grade = double.Parse(this.textBoxGPA.Text);

            Person students = new Person(name, year, grade);
            this.classroom.addStudent(students);

            textBoxListName.Text = this.classroom.ShowStudent();
            textBoxNumofAge.Text = this.classroom.ShowAllAge().ToString();
            this.classroom.SetGrade();
            this.textBoxGPAmax.Text = this.classroom.ShowMaxGrade().ToString();
            this.textBoxGPAmin.Text = this.classroom.ShowMinGrade().ToString();
            this.textBoxNammax.Text = this.classroom.ShowMaxGradeName();
            this.textBoxNamemin.Text = this.classroom.ShowMinGradeName();
            AvgGPA = this.classroom.ShowAvgGPA();
            this.textBoxGPAavg.Text = AvgGPA.ToString();

            //string input_name = this.textBoxName.Text;

            //string input_year = this.textBoxbYear.Text;

            //string input_grade = this.textBoxGPA.Text;
            //int iYear = Int32.Parse(input_year);
            //double iGrade = Double.Parse(input_grade);

            ////clear textbox
            //this.textBoxbYear.Text = "";
            //this.textBoxName.Text = "";
            //this.textBoxGPA.Text = "";
            //this.textBoxGPAmax.Text = "";
            //this.textBoxGPAmin.Text = "";

            ////create object from Person class
            //Person person = new Person(input_name, iYear, iGrade);
            //this.classroom.addPerson2Class(person);

            ////display person
            //this.textBoxListName.Text = this.classroom.showAllPersoninClass();

            ////display Grade
            //this.textBoxNammax.Text =

            ////display total age of class
            //this.textBoxNumofAge.Text = "";

            ////max min of Grade
            //if (iGrade > maxGrade)
            //{
            //    maxGrade = iGrade;
            //}
            //if (iGrade < minGrade)
            //{
            //    minGrade = iGrade;
            //}

            ////display Max Min Grade
            //this.textBoxGPAmax.Text = this.textBoxGPAmax.Text + maxGrade;
            //this.textBoxGPAmin.Text = this.textBoxGPAmin.Text + minGrade;


        }
    }
}