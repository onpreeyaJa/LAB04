using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    public class Person
    {
        private string name;
        private double grade;
        private int birthday;

        public Person(string name ,int bYear, double dGrade) {
            this.name = name;
            this.birthday = bYear;
            this.grade = dGrade;
        }
        public double getdGrade() { 
            return grade;
        }
        public string getName() {
            return this.name;
        }
    }
}
