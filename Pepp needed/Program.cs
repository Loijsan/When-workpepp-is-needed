using System;

namespace Pepp_needed
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello! Do you need som pepp? Please make your choice:");
            Console.WriteLine();
            Console.WriteLine("1. How long until the weekend?");
            Console.WriteLine();
            Console.WriteLine("2. How long until it is monday again?");
            Console.WriteLine();
            Console.WriteLine("Number: ");
            string usersChoice = Console.ReadLine();
            int menuChoice;
            bool correctInput = Int32.TryParse(usersChoice, out menuChoice);

            if (menuChoice == 1 || menuChoice == 2)
            {
                switch (menuChoice)
                {
                    case 1:
                        TimeToWeekend();
                        break;
                    case 2:
                        TimeToMonday();
                        break;
                }
            }
            else
            {
                Console.Clear();
                Program.Main();
            }
            
        }
        public static void TimeToWeekend()
        {
            DateTime currentTime = DateTime.Now;
            var dayToday = currentTime.DayOfWeek;
            var nextFriday = DayOfWeek.Friday;
            var diff = nextFriday - dayToday;

            DateTime fridayV26 = new DateTime(2021, 07, 02, 16, 30, 00);
            DateTime fridayV27 = new DateTime(2021,07,09,16,30,00);
            DateTime fridayV28 = new DateTime(2021, 07, 16, 16, 30, 00);
            DateTime fridayV29 = new DateTime(2021, 07, 23, 16, 30, 00);
            DateTime fridayV30 = new DateTime(2021, 07, 30, 16, 30, 00);
            DateTime fridayV31 = new DateTime(2021, 08, 06, 16, 30, 00);
            DateTime fridayV32 = new DateTime(2021, 08, 13, 16, 30, 00);
            DateTime fridayV33 = new DateTime(2021, 08, 20, 16, 30, 00);
            if (currentTime < fridayV26)
            {
                WeekendCounter(fridayV26, currentTime);
            }
            else if (currentTime < fridayV27)
            {
                WeekendCounter(fridayV27, currentTime);
            }
            else if (currentTime < fridayV28)
            {
                WeekendCounter(fridayV28, currentTime);
            }
            else if (currentTime < fridayV29)
            {
                WeekendCounter(fridayV29, currentTime);
            }
            else if (currentTime < fridayV30)
            {
                WeekendCounter(fridayV30, currentTime);
            }
            else if (currentTime < fridayV31)
            {
                WeekendCounter(fridayV31, currentTime);
            }
            else if (currentTime < fridayV32)
            {
                WeekendCounter(fridayV32, currentTime);
            }

            Console.WriteLine("The person that coded this program has left for school, expand it if you want ;)");

        }
        public static void TimeToMonday()
        {
            DateTime currentTime = DateTime.Now;
            DateTime mondayV28 = new DateTime(2021, 07, 12, 08, 15, 00);
            DateTime mondayV29 = new DateTime(2021, 07, 19, 08, 15, 00);
            DateTime mondayV30 = new DateTime(2021, 07, 26, 08, 15, 00);
            DateTime mondayV31 = new DateTime(2021, 08, 02, 08, 15, 00);
            DateTime mondayV32 = new DateTime(2021, 08, 9, 08, 15, 00);
            DateTime mondayV33 = new DateTime(2021, 08, 16, 08, 15, 00);
            DateTime mondayV34 = new DateTime(2021, 08, 23, 08, 15, 00);

            if (currentTime < mondayV28)
            {
                MondayCounter(mondayV28, currentTime);
            }
            else if (currentTime < mondayV29)
            {
                MondayCounter(mondayV29, currentTime);
            }
            else if (currentTime < mondayV30)
            {
                MondayCounter(mondayV30, currentTime);
            }
            else if (currentTime < mondayV31)
            {
                MondayCounter(mondayV31, currentTime);
            }
            else if (currentTime < mondayV32)
            {
                MondayCounter(mondayV32, currentTime);
            }
            else if (currentTime < mondayV33)
            {
                MondayCounter(mondayV33, currentTime);
            }
            else if (currentTime < mondayV34)
            {
                MondayCounter(mondayV34, currentTime);
            }
            Console.WriteLine("The person that coded this program has left for school, expand it if you want ;)");
        }
        public static void WeekendCounter(DateTime closestFriday, DateTime currentTime)
        {
            TimeSpan timeLeftToFriday = closestFriday - currentTime;
            //var minutesLeft = (timeLeftToFriday.Days * 1440) + timeLeftToFriday.Minutes;
            Console.Clear();
            if (timeLeftToFriday.Days > 0)
            {
                Console.WriteLine($"Juhu, only {timeLeftToFriday.Days} day(s), {timeLeftToFriday.Hours} hour(s), and {timeLeftToFriday.Minutes} minute(s) left until the weekend!");
                Program.MenuReturner();
            }
            else if (timeLeftToFriday.Hours > 0)
            {
                Console.WriteLine($"We are getting closer! Only {timeLeftToFriday.Hours} hour(s), and {timeLeftToFriday.Minutes} minute(s) left!");
                Program.MenuReturner();
            }
            Console.WriteLine($"Just {timeLeftToFriday.Minutes} minute(s) left to the weekend! PARTY!");
            Program.MenuReturner();
        }
        public static void MondayCounter(DateTime closestMonday, DateTime currentTime)
        {
            TimeSpan timeLeftToMonday = closestMonday - currentTime;
            //var minutesLeft = (timeLeftToMonday.Days * 1440) + timeLeftToMonday.Minutes;
            Console.Clear();
            if (timeLeftToMonday.Days > 0 )
            {
                Console.WriteLine($"Woop woop, only {timeLeftToMonday.Days} day(s), {timeLeftToMonday.Hours} hour(s), and {timeLeftToMonday.Minutes} minute(s) left until it is monday again!");
                Program.MenuReturner();
            }
            else if (timeLeftToMonday.Hours > 0)
            {
                Console.WriteLine($"Hang in there! {timeLeftToMonday.Hours} hour(s) left until it's monday again!");
                Program.MenuReturner();
            }
            Console.WriteLine($"Just {timeLeftToMonday.Minutes} minute(s) left until it is monday again!");
            Program.MenuReturner();
        }
        public static void MenuReturner()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
            Program.Main();
        }
    }
}
