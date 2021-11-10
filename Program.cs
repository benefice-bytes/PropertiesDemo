using System;
using System.Collections.Generic;

namespace PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee{Id=1001, Name="Ashok", Salary=98000};
            Console.WriteLine(employee);

            List<Employee> employees = new List<Employee>{
                new Employee{Id=1002, Name="Sujana", Salary=97000.00},
                new Employee{Id=1003, Name="Mounika", Salary=124000}
            };

            foreach(Employee emp in employees)
                Console.WriteLine(emp);
        }
    }
}
