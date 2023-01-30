using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    public class Classroom
    {
        private string name;
        List<Person> persons = new List<Person>();
        private double AvgGPA = 0;

        public Classroom(string name )
        {
            this.name = name;
        }
        public void addPerson2Class(Person p) {
            this.persons.Add( p );
        }
        public string showAllPersoninClass() {
            string result = "";
            foreach (Person p in this.persons) {
                result += p.getName() + "\r\n";
            }
            return result;      
        }
    }
}
