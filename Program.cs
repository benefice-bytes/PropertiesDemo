using System;

namespace PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee{Id=1001, Name="Ashok", Salary=98000};
            Console.WriteLine(employee);
        }
    }
}
