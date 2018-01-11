using System;

/*
 * Катя узнала, что ей для сна надо X минут. В отличие от Коли,
 * Катя ложится спать после полуночи в H часов и M минут. Помогите
 * Кате определить, на какое время ей поставить будильник, чтобы он
 * прозвенел ровно через X минут после того, как она ляжет спать.
 *
 * На стандартный ввод, каждое в своей строке, подаются значения XX,
 * H и M. Гарантируется, что Катя должна проснуться в тот же день,
 * что и заснуть. Программа должна выводить время, на которое нужно
 * поставить будильник: в первой строке часы, во второй — минуты.
 *
 *
 *
 * Sample Input 1:
 *
 *  480
 *  1
 *  2
 * Sample Output 1:
 *
 *  9
 *  2
 * Sample Input 2:
 *
 *  475
 *  1
 *  55
 * Sample Output 2:
 *
 *  9
 *  50
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());
            int hour = Int32.Parse(Console.ReadLine());
            int min = Int32.Parse(Console.ReadLine());
            int mins = hour * 60 + min + number;
            Console.WriteLine(mins / 60);
            Console.WriteLine(mins % 60);
        }
    }
}
