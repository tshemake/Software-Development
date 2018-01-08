using System;

/*
 * В этом задании в нашу функцию testDateTime передаются две
 * строки вида "03 November 2017 04:17". 
 * Вам нужно превратить строки в даты, сравнить их. Для той,
 * что больше получить день недели и вернуть его из функции.
 *
 * Название дня недели должно быть по-русски, с большой буквы, например: "Понедельник".
 *
 * Sample Input 1:
 *
 *  19 October 1909 10:27
 *  28 March 1909 00:59
 * Sample Output 1:
 *
 *  Вторник
 * Sample Input 2:
 *
 *  04 August 1909 00:24
 *  03 November 1909 06:54
 * Sample Output 2:
 *
 *  Среда
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testDateTime("19 October 1909 10:27", "28 March 1909 00:59"));
            Console.WriteLine(testDateTime("04 August 1909 00:24", "03 November 1909 06:54"));
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
                    dayName = "Воскресенье";
                    break;
                case DayOfWeek.Monday:
                    dayName = "Понедельник";
                    break;
                case DayOfWeek.Tuesday:
                    dayName = "Вторник";
                    break;
                case DayOfWeek.Wednesday:
                    dayName = "Среда";
                    break;
                case DayOfWeek.Thursday:
                    dayName = "Четверг";
                    break;
                case DayOfWeek.Friday:
                    dayName = "Пятница";
                    break;
                case DayOfWeek.Saturday:
                    dayName = "Суббота";
                    break;
            }
            return dayName;
        }
    }
}
