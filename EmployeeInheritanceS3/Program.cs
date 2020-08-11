using EmployeeInheritanceS3.Entities;
using System;

namespace EmployeeInheritanceS3
{
    class Program
    {
        static void Main()
        {
            SalariedEmployee salaryEmployee = new SalariedEmployee("Hober", "Mallow", "9238923892", 6000);
            Console.WriteLine($"Salary Employees ugeløn er: {salaryEmployee.GetPaymentAmount()}");
            HourlyEmployee hourEmployee = new HourlyEmployee("Gaal", "Dornick", "24434324234423", 120, 40);
            Console.WriteLine($"Hourly Employees løn for 40 timer, 120 i timen er:  {hourEmployee.GetPaymentAmount()}");

        
            CommissionEmployee commissioner = new CommissionEmployee("Ebling", "Riose", "4384843", 25, 5);

            Console.WriteLine($"Commissioner bygger 25 ting der koster 100 hver, 2500 i alt, han tjener 5% som er {commissioner.GetPaymentAmount()}");

        }

    }
}