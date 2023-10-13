using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_OOP_Generic_Collections
{
    internal class Employee
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        public Employee(int id, string name, string gender, double salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        // Print method for Employee objects, instead of repeating the Console.WriteLines() as I previously did.
        public void Print()
        {
            Console.Write("Id: {0}, ", Id);
            Console.Write("Name: {0}, ", Name);
            Console.Write("Gender: {0}, ", Gender);
            Console.WriteLine("Salary: {0}.", Salary);
        }
    }
}
