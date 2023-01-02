using LitwareLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_3
{
    class MarketingExecutive : Employee
    {
        private readonly double kilometerTravel;
        private double tourAllowances;
        private double telephoneAllowances;

        public double KilometerTravel { get; set; }
        public double TourAllowances { get; set; }
        public double TelephoneAllowances { get; set; }
        public MarketingExecutive(int empNo, string empName, double salary) : base(empNo, empName, salary)
        {
            this.EmpNo = empNo;
            this.EmpName = empName;
            this.Salary = salary;
            Console.WriteLine("Enter Kilometer Traveled");
            this.KilometerTravel = Convert.ToDouble(Console.ReadLine());
            this.TourAllowances = KilometerTravel * 5;
            this.TelephoneAllowances = 1000;
            GrossSalary = CalculateSalary() + KilometerTravel + TourAllowances + TelephoneAllowances;

        }
    }
}
