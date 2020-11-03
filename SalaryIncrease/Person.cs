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
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;


        private string FirstName
        {
            get { return this.firstName; }
        }
        private string LastName
        {
            get { return this.lastName; }
        }
        private int Age
        {
            get { return this.age; }
        }



        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.salary} years old.";
        }


        //increase salary
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.salary += this.salary * percentage / 100;
            }
            else
            {
                this.salary += this.salary * percentage / 200;
            }
        }
    }
}
