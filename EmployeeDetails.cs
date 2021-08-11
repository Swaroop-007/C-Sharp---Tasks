using System;
using System.Collections.Generic;
using System.Text;

namespace myappAug10
{
    class EmployeeSalary
    {
        private int empid;
        string name;
        private double basicSal, HRAl, TravelAl;
        double taxDeduction;

        public EmployeeSalary(int empid,string name,double basicSal,double HRAl, double TravelAl,double taxDeduction)
        {
            this.empid = empid;
            this.name = name;
            this.basicSal = basicSal;
            this.HRAl = HRAl;
            this.TravelAl = TravelAl;
            this.taxDeduction = taxDeduction;
        }
        public void getDetails()
        {
            Console.WriteLine($"Employee Id is {this.empid}");
            Console.WriteLine($"Employee Basic Salary is {this.basicSal}");
            Console.WriteLine($"Employee HR Allowance Id is {this.HRAl}");
            Console.WriteLine($"Employee Travel Allowance is {this.TravelAl}");
            Console.WriteLine($"Employee Tax Deduction is {this.taxDeduction} %");
        }
    }
    class EmployeeDetails
    {
        public static void Main()
        {
            EmployeeSalary e1 = new EmployeeSalary(12345, "S", 2000.0, 400, 200, 5);
            e1.getDetails();
        }
    }
}
