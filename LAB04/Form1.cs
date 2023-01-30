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
            classroom = new Classroom("OPP");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string input_name = this.textBoxName.Text;

            string input_year = this.textBoxbYear.Text;

            string input_grade = this.textBoxGPA.Text;
            int iYear = Int32.Parse(input_year);
            double iGrade = Double.Parse(input_grade);

            //clear textbox
            this.textBoxbYear.Text = "";
            this.textBoxName.Text = "";
            this.textBoxGPA.Text = "";
            this.textBoxGPAmax.Text = "";
            this.textBoxGPAmin.Text = "";

            //create object from Person class
            Person person = new Person(input_name, iYear , iGrade);
            this.classroom.addPerson2Class(person);

            //display person
            this.textBoxListName.Text = this.classroom.showAllPersoninClass();

            //display Grade
            this.textBoxNammax.Text = 

            //display total age of class
            this.textBoxNumofAge.Text = "";

            //max min of Grade
            if (iGrade > maxGrade)
            {
                maxGrade = iGrade;
            }
            if (iGrade < minGrade)
            {
                minGrade = iGrade;
            }

            //display Max Min Grade
            this.textBoxGPAmax.Text = this.textBoxGPAmax.Text + maxGrade;
            this.textBoxGPAmin.Text = this.textBoxGPAmin.Text + minGrade;


        }
    }
}