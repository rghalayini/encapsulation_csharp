using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Encapsulation
{
    public class Person
    {
        //constructor for person
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        private string firstName;
        private string lastName;
        private int age;


        
        public string FirstName
        {
            get { return this.firstName; }
        }
        public string LastName
        {
            get { return this.lastName; }
        }
        public int Age
        {
            get { return this.age; }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }
    }
}
