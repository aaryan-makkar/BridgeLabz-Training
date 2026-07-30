using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    internal class Employee
    {
        public string name;
        public int id;
        public double salary;

        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"The name of the employee is {name}, the id is {id}, the salary is {salary}");
        }
        
    }
}
