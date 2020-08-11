namespace EmployeeInheritanceS3.Entities
{
    public class SalariedEmployee: Employee
    {
        protected double weeklySalary;

        public SalariedEmployee(string firstName, string lastName, string socialSecurityNumber, double weeklySalary)
            : base(firstName, lastName, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }
        public virtual double WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if(weeklySalary != value)
                {
                    weeklySalary = value;
                }
            }
        }
        // Get yearly salary
        public override double GetPaymentAmount()
        {
            return weeklySalary * 4;
        }
    }
}