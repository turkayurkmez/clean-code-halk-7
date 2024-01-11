using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Library
{
    public class MailService
    {
        public void SendMail(List<Company> companies, List<TimeSheetEntry> timeSheetEntries)
        {
            double totalHoursInAWeek = 0;
            foreach (var company in companies)
            {
                totalHoursInAWeek = getTotalHours(timeSheetEntries, totalHoursInAWeek, company);
                Console.WriteLine($"Simulating Sending email to {company.Name}");
                Console.WriteLine("Your bill is $" + (totalHoursInAWeek * company.PaymentPerHour) + " for the hours worked.");
            }
        }

        private double getTotalHours(List<TimeSheetEntry> timeSheetEntries, double totalHoursInAWeek, Company company)
        {
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                if (timeSheetEntries[i].WorkDone.ToLower().Contains(company.Name.ToLower()))
                {
                    totalHoursInAWeek += timeSheetEntries[i].HoursWorked;
                }
            }

            return totalHoursInAWeek;
        }
    }
}
