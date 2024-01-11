namespace CleanCode.Library
{
    public class CalculateService
    {
        public double CalculateExtraPayment(double totalHours, int maxHourInAWeek = 40)
        {
            if (totalHours > maxHourInAWeek)
            {
                double extraUnit = 15;
                double standartUnit = 10;

                var normalWeeklyPayment = maxHourInAWeek * standartUnit;

                var extraHour = totalHours - maxHourInAWeek;
                var extraPayment = extraHour * extraUnit;
                var totalExtra = normalWeeklyPayment + extraPayment;

                return totalExtra;
                //$"You will get paid ${totalExtra} for your work.");

            }
            else
            {
                return totalHours * 10;
                //Console.WriteLine("You will get paid $" + (totalHours * 10) + " for your time.");
            }
        }

    }
}