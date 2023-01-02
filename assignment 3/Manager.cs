using System;
using System.Collections.Generic;
using System.Text;

namespace LitwareLib 
{
    class Manager : Employee
    {
        private double petrolAllowance, foodAllowance, otherAllowance;
        public double PetrolAllowance { get; set; }
        public double FoodAllowance { get; set; }
        public double OtherAllowance { get; set; }
        public Manager(int empNo, string empName, double salary):base(empNo,empName,salary)
        {
            this.EmpNo = empNo;
            this.EmpName = empName;
            this.Salary = salary;
           this.PetrolAllowance = 0.08*Salary;
           this.FoodAllowance = 0.13 * Salary;
            this.OtherAllowance =0.03*Salary;
            this.GrossSalary = CalculateSalary() + PetrolAllowance + FoodAllowance + OtherAllowance;
            
        }

       /* public void displayEmp()
        {
        Console.WriteLine("The Emp Id is " + EmpNo + " \nThe Emp Name is " + EmpName + "\n GrossSalary is" + GrossSalary + "\n NetSalary is" +netSalary + "\n pf is"+ pF);
        }*/

    }
}
