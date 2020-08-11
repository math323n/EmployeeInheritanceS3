using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInheritanceS3.Entities
{
    public abstract class Employee : IPayable
    {
        protected string firstName;
        protected string lastName;
        protected string socialSecurityNumber;


        protected Employee(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        public virtual string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if(firstName != value)
                {
                    firstName = value;
                }
            }
        }

        public virtual string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if(lastName != value)
                {
                    lastName = value;
                }
            }
        }

        public virtual string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
            set
            {
                if(socialSecurityNumber != value)
                {
                    socialSecurityNumber = value;
                }
            }
        }

        public virtual double GetPaymentAmount()
        {
            return 1 + 1;
        }
    }
}