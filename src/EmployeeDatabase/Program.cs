using System;
using System.Collections.Generic;

namespace EmployeeDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

             string []  employees=  { "John", "Frank", "Jim", "JJ" };
             var salaries = new []{5000, 6000, 7000, 8000};

            if(employees.Length > 0) 
            {
                foreach(string employee in employees)
                {
                     Console.WriteLine(employee);
                   
                }
                foreach(int salary in salaries)
                {
                     Console.WriteLine(salary);
                   
                }
                
            } else {
                 Console.WriteLine("There are no employees in database");
            }
            
           
        }
    }
}
