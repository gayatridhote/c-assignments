using assignment_3;
using System;

namespace LitwareLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrintable emp, man, mar;
            emp = new Employee(100, "Rani",7000);
            man = new Manager(273, "Vikas", 7000);
            mar = new MarketingExecutive(322, "Manish", 7000);
            //How to access the Methods outside the class
            emp.CalculateSalary();
            emp.DisplayEmp();
            man.CalculateSalary();
            man.DisplayEmp();
            mar.CalculateSalary();
            mar.DisplayEmp();
            Console.ReadKey();
        }
    }
}
