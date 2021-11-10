using System;

namespace PropertiesDemo
{
    public class Employee
    {
        public int Id{get;set;}
        public string Name {get;set;} 
        public double Salary {get;set;}

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Salary}";
        }
    }
}