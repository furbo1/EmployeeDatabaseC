using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDatabase 
{
    class Employee
    {
        public int Salary { get; }
        public string Name { get; }

        public Employee(int salary, string name)
        {
            Salary = salary;
            Name = name;
        }

    }
}