using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solv__assignmant_2_oop
{
    //Employee is identified by an ID, Name, security level, salary, hire date and Gender.

    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public Gender Gender { get; set; }

        public Employee(int id, string name, Gender gender, double salary, HiringDate hireDate, SecurityLevel level)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            HireDate = hireDate;
            SecurityLevel = level;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {Gender}, Salary: {String.Format("{0:C}", Salary)}, Hire Date: {HireDate}, Security Level: {SecurityLevel}";
        }

    }
}
