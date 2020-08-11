using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInheritanceS3.Entities
{
    public class HourlyEmployee: Employee
    {
        protected double wage;
        protected double hours;

        public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber, double wage, double hours)
            : base(firstName, lastName, socialSecurityNumber)
        {
            Wage = wage;
            Hours = hours;
        }

        public virtual double Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if(wage != value)
                {
                    wage = value; 
                }
            }
        }
        public virtual double Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if(hours != value)
                {
                    hours = value;
                }
            }
        }

        public override double GetPaymentAmount()
        {
            return wage * hours;
        }
    }
}
