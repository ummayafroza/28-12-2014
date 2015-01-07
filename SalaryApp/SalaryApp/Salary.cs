namespace SalaryApp
{
    internal class Salary
    {
        public Salary(double basic, double medicalPercent, double convPercent)
        {
            Basic = basic;
            MedicalPercent = medicalPercent;
            ConvPercent = convPercent;
        }

        public double ConvPercent { get; set; }

        public double MedicalPercent { get; set; }

        public double Basic { get; set; }
        public int NoOfIncrements { get; private set; }

        public double GetConvAmount()
        {
            return (ConvPercent*Basic)/100;
        }

        public double GetMedicalAmount()
        {
            return (MedicalPercent*Basic)/100;
        }

        public double GetTotal()
        {
            return Basic + GetConvAmount() + GetMedicalAmount();
        }

        public void Increase(double basicPercentToBeIncreased)
        {
            double amountToBeIncreased = (basicPercentToBeIncreased*Basic)/100;
            Basic += amountToBeIncreased;
            NoOfIncrements++;
        }
    }
}