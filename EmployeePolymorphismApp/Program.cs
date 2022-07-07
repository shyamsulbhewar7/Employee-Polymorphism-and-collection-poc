using EmployeePolymorphismApp.Model;
using System;

namespace EmployeePolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Manager(1, "shyam", 30000);
            PrintDetails(e1);
            Employee e2 = new Developer(2, "Sumeer", 28000);
            PrintDetails(e2);
            Employee e3 = new Tester(3, "Deepak", 25000);
            PrintDetails(e3);
        }
        public static void PrintDetails(Employee e)
        {
            Console.WriteLine("Employee details : ");
            Console.WriteLine("Name : " + e.Name);
            Console.WriteLine("Basic salary : " + e.Salary);
            Console.WriteLine("Total salary : " + e.TotalSalary());
            Console.WriteLine("Annual CTC : " + e.AnnualCTC());
        }
    }
}
