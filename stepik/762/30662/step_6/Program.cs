using System;

/*
 * На стандартный ввод (stdin) скрипта переданы 3 случайных
 * числа a, b и c, разделенные пробелами.
 *
 * Необходимо передать числа на стандартный вывод (stdout) в
 * порядке a, c и b, разделенные запятыми.
 *
 * Передать числа на стандартный вывод можно с помощью echo.
 *
 * Sample Input:
 *
 *  0 4 2
 * Sample Output:
 *
 *  0,2,4
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arguments = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("{0},{2},{1}", arguments);
        }
    }
}
