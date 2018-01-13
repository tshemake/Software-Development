using System;

/*
 * In this task, two lines of the form "03 November 2017 04:17"
 * are passed to our testDateTime function.
 * You need to turn the rows into dates, compare them. For the one
 * that is more to get the day of the week and return it from function.
 *
 * The name of the day of the week should be in English, with a
 * capital letter, for example: "Monday".
 * Sample Input 1:
 *
 *  21 May 1909 22:10
 *  04 December 1909 19:00
 * Sample Output 1:
 *
 *  Saturday
 * Sample Input 2:
 *
 *  24 January 1909 08:35
 *  21 May 1909 11:40
 * Sample Output 2:
 *
 *  Friday
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testDateTime("21 May 1909 22:10", "04 December 1909 19:00"));
            Console.WriteLine(testDateTime("24 January 1909 08:35", "21 May 1909 11:40"));
        }

        private static string testDateTime(string a, string b)
        {
            DateTime dt1 = DateTime.Parse(a);
            DateTime dt2 = DateTime.Parse(b);
            DayOfWeek day = (dt1 >= dt2) ? dt1.DayOfWeek : dt2.DayOfWeek;
            string dayName = "";
            switch (day)
            {
                case DayOfWeek.Sunday:
                    dayName = "Sunday";
                    break;
                case DayOfWeek.Monday:
                    dayName = "Monday";
                    break;
                case DayOfWeek.Tuesday:
                    dayName = "Tuesday";
                    break;
                case DayOfWeek.Wednesday:
                    dayName = "Wednesday";
                    break;
                case DayOfWeek.Thursday:
                    dayName = "Thursday";
                    break;
                case DayOfWeek.Friday:
                    dayName = "Friday";
                    break;
                case DayOfWeek.Saturday:
                    dayName = "Saturday";
                    break;
            }
            return dayName;
        }
    }
}
