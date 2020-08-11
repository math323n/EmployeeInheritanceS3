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
            BasePlusCommissionEmployee basePlus = new BasePlusCommissionEmployee("Ebling", "Riose", "4384843", 25, 5, 1000);

            Console.WriteLine($"Commissioner sælger 25 ting der koster 100 hver, 2500 i alt, han tjener 5% som er {commissioner.GetPaymentAmount()}");
            Console.WriteLine($"BasePlusCommissionEmployee har en ugeløn på 1000, han sælger også 25 ting der koster 100 hver, " +
                $"og tjener 5% af det. I alt tjener han; {basePlus.GetPaymentAmount()}");

            // Invoice
            Invoice order = new Invoice("34343", "A Foundation Starship", 4, 92400);
            double orderResult = order.GetPaymentAmount();
            Console.WriteLine($"Faktura for invoice er Antal(${order.Quantity}) gange pris({order.PricePerItem}) som er: {orderResult}");
        }

    }
}