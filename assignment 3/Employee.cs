using assignment_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace LitwareLib
{   
    class Employee : IPrintable
    {
        private int empNo;
        private string empName;
        private double salary, HRA, TA, DA, PF, TDS, NetSalary, grossSalary;
        public double GrossSalary { get; set; }
        public double Salary { get; set; }
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public double hRA { get; set; }
        public double tA { get; set; }
        public double dA { get; set; }
        public double pF { get; set; }
        public double tDS { get; set; }
        public double netSalary { get; set; }

        public Employee(int empNo, string empName, double salary)
        {
            this.EmpNo = empNo;
            this.EmpName = empName;
            this.Salary = salary;

            
            {
                if (salary < 5000)
                {
                    this.hRA = 0.1 * Salary;
                    this.tA = 0.05 * Salary;
                    this.dA = 0.15 * Salary;
                }
                else if (salary < 10000)
                {
                    this.hRA = 0.15 * Salary;
                    this.tA = 0.1 * Salary;
                    this.dA = 0.2 * Salary;
                }
                else if (salary < 15000)
                {
                    this.hRA = 0.2 * Salary;
                    this.tA = 0.15 * Salary;
                    this.dA = 0.25 * Salary;
                }
                else if (salary < 20000)
                {
                    this.hRA = 0.25 * Salary;
                    this.tA = 0.25 * Salary;
                    this.dA = 0.30 * Salary;
                }
                else
                {
                    this.hRA = 0.3 * Salary;
                    this.tA = 0.25 * Salary;
                    this.dA = 0.35 * Salary;
                }
            }
             this.GrossSalary = CalculateSalary();
            this.pF = 0.1 * GrossSalary;
            this.tDS = 0.18 * GrossSalary;
            this.netSalary = GrossSalary - (pF + tDS);
        }

        public double CalculateSalary()
        {
            double y= Salary + hRA + tA + dA;
           
            return y; 
        }
        public void DisplayEmp()
        {
            Console.WriteLine("The Emp Id is " + EmpNo + " \nThe Emp Name is " + EmpName + "\n GrossSalary is" + GrossSalary + "\n NetSalary is" + (GrossSalary - (pF + tDS)) + "\n pf is" + (0.1 * GrossSalary));
        }
    }
}
