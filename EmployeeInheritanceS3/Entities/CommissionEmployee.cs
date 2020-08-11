using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInheritanceS3.Entities
{
    public class CommissionEmployee: Employee
    {
        protected double grossSales;
        protected double commisissonRate;

        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, double grossSales, double commisissonRate)
            : base(firstName, lastName, socialSecurityNumber)
        {
            GrossSales = grossSales;
            CommissionRate = commisissonRate;
        }

        protected double GrossSales
        {
            get
            {
                return grossSales;
            }

            set
            {

                if(grossSales != value)
                {
                    grossSales = value;
                }
            }
        }

        protected double CommissionRate
        {
            get
            {
                return commisissonRate;
            }

            set
            {

                if(commisissonRate != value)
                {
                    commisissonRate = value;
                }
            }
        }

        public override double GetPaymentAmount()
        {
            double result = grossSales * 100;
            double percent = commisissonRate;
            return (result * percent / 100);
        }
    }
}
