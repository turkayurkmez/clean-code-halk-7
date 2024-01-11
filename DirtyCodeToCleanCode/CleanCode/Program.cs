using CleanCode.Library;

namespace CleanCode;
class Program
{
    static void Main(string[] args)
    {
        //double totalHoursInAWeek = 0; ;
        var timeSheetEntries = loadEntries();
        var companies = new CompanyService().GetCompanies();
        MailService mailService = new MailService();
        mailService.SendMail(companies, timeSheetEntries);
        var totalHours = timeSheetEntries.Sum(t => t.HoursWorked);
        CalculateService calculateService = new CalculateService();
        var payment = calculateService.CalculateExtraPayment(totalHours);
        Console.WriteLine($"You will get paid ${payment} for your work.");
        Console.WriteLine();
        Console.Write("Press any key to exit application...");
        Console.ReadKey();
    }

    static List<TimeSheetEntry> loadEntries()
    {
        string workDescription;
        string rawTimeWorked;
        double timeForWork;
        string answer = string.Empty;
        List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();

        do
        {
            Console.Write("Enter what you did: ");
            workDescription = Console.ReadLine();

            Console.Write("How long did you do it for: ");
            rawTimeWorked = Console.ReadLine();

            timeForWork = getTimeForWorkFromUser(rawTimeWorked);

            TimeSheetEntry timeSheetEntry = new TimeSheetEntry
            {
                HoursWorked = timeForWork,
                WorkDone = workDescription
            };
            timeSheetEntries.Add(timeSheetEntry);
            Console.Write("Do you want to enter more time (yes/no): ");
            answer = Console.ReadLine();
        } while (answer.ToLower() == "yes");


        return timeSheetEntries;
    }

    private static double getTimeForWorkFromUser(string rawTimeWorked)
    {

        double timeForWork = 0;
        while (!double.TryParse(rawTimeWorked, out timeForWork))
        {
            Console.WriteLine();
            Console.WriteLine("Invalid number given");
            Console.Write("How long did you do it for: ");
            rawTimeWorked = Console.ReadLine();
        }
        return timeForWork;
    }






}


