using System.Globalization;

namespace Aufgabe_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gib ein Geburtsdatum ein: ");
            DateTime userDate = Convert.ToDateTime(Console.ReadLine());
            DateTime Enddate = DateTime.Today;
            DateTime dateOnly = userDate.Date;

            TimeSpan ts = Enddate - userDate;

            int userAgeyear = DateTime.Now.Year - userDate.Year;
            DateTime today = DateTime.Now;
            if (userDate > today.AddYears(-userAgeyear))
            {
                userAgeyear--;
            }
            string AgeYear = Convert.ToString(userAgeyear);
            Console.WriteLine($"Alter in Jahren: {AgeYear}");

            int userAgemonth = (Enddate.Year - userDate.Year) * 12 + Enddate.Month - userDate.Month + (Enddate.Day >= userDate.Day ? 0 : -1);
            Console.WriteLine($"Alter in Monaten: {userAgemonth}");

            int differenceindays = ts.Days;

            int weeks = Convert.ToInt32(ts.Days);
            int diffrenceweeks = weeks / 7;

            Console.WriteLine($"Alter in Wochen: {diffrenceweeks}");


            Console.WriteLine($"Alter in Tagen: {differenceindays}");

        }
    }
}
