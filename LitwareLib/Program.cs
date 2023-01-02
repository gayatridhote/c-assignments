using System;

namespace LitwareLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee emp = new Employee(100, "Rani",7000);
            //How to access the Methods outside the class
            emp.CalculateSalary();
            emp.displayEmp();
            Console.ReadKey();



        }
    }
}
