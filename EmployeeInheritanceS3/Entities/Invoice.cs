using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInheritanceS3.Entities
{
    public class Invoice : IPayable
    {
        protected string partNumber;
        protected string partDescription;
        protected int quantity;
        protected double pricePerItem;

        public Invoice(string partNumber, string partDescription, int quantity, double pricePerItem)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            PricePerItem = pricePerItem;
        }

        public virtual string PartNumber
        {
            get
            {
                return partNumber;
            }
            set
            {
                if(partNumber != value)
                {
                    partNumber = value;
                }
            }
        }

        public virtual string PartDescription
        {
            get
            {
                return partDescription;
            }
            set
            {
                if(partDescription != value)
                {
                    partDescription = value;
                }
            }
        }

        public virtual int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if(quantity != value)
                {
                    quantity = value;
                }
            }
        }

        public virtual double PricePerItem
        {
            get
            {
                return pricePerItem;
            }
            set
            {
                if(pricePerItem != value)
                {
                    pricePerItem = value;
                }
            }
        }

        public double GetPaymentAmount()
        {
            return 1 + 1;
        }
    }
}
