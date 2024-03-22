namespace Domain_Driven_Design_Solution.Library_Domain.Entities.Payslips
{
    public class PayslipValueObject
    {
        private float workingDays;
        private float coefficientsSalary;
        private decimal bonus;

        public PayslipValueObject(float workingDays, float coefficientsSalary, decimal bonus)
        {
            this.workingDays = workingDays;
            this.coefficientsSalary = coefficientsSalary;
            this.bonus = bonus;
        }

        public decimal TotalSalary { get; internal set; }
    }
}
