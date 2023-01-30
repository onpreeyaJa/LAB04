using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    internal class Classroom
    {
        public List<Person> StudentList = new List<Person>();
        public List<int> YearList = new List<int>();
        public List<double> GradeList = new List<double>();
        public List<string> NameList = new List<string>();

        public void addStudent(Person students)
        {
            StudentList.Add(students);
            YearList.Add(students.Year);

        }
        public string ShowStudent()
        {
            string results = "";
            foreach (var student in StudentList)
            {
                results += student.Name + "\r\n";
            }
            return results;
        }
        public int ShowAllAge()
        {

            return YearList.Sum();
        }

        public void SetGrade()
        {
            foreach (var student in StudentList)
            {
                GradeList.Add(student.Grade);
                NameList.Add(student.Name);
            }
        }
        public double ShowMaxGrade()
        {
            return GradeList.Max();
        }
        public double ShowMinGrade()
        {
            return GradeList.Min();
        }

        public string ShowMaxGradeName()
        {
            return NameList[GradeList.IndexOf(GradeList.Max())];
        }
        public string ShowMinGradeName()
        {
            return NameList[GradeList.IndexOf(GradeList.Min())];
        }

        public double ShowAvgGPA()
        {
            return GradeList.Sum() / GradeList.Count();
        }
    }
}
