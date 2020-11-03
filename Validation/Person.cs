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
            this.Salary = salary;
        }

        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName
        {
            get 
            { 
                return this.firstName; 
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First Name cannot contain fewer than 3 symbols!");
                }
                this.firstName = value; ;
            }
        }
        public string LastName
        {
            get 
            { 
                return this.lastName; 
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last Name cannot contain fewer than 3 symbols!");
                }
                this.lastName = value;
            }
        }
        public int Age
        {
            get 
            { 
                return this.age; 
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                this.age = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return this.Salary;
            }
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 dollars");
                }
                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old and receives {this.salary}$ for salary.";
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

        // validation of data

    }
}
