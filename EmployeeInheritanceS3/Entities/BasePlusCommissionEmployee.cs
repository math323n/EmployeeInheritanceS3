using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInheritanceS3.Entities
{
    public class BasePlusCommissionEmployee: CommissionEmployee
    {
        protected double baseSalary;

        public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecurityNumber,
            double grossSales, double commisissonRate, double baseSalary)
            : base(firstName, lastName, socialSecurityNumber, grossSales, commisissonRate)
        {
            BaseSalary = baseSalary;
        }

        public virtual double BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if(baseSalary != value)
                {
                    baseSalary = value;
                }
            }
        }

        public override double GetPaymentAmount()
        {
            double sales = grossSales * 100;
            double percent = commisissonRate;
            return baseSalary + (sales * percent / 100);
        }
    }
}
