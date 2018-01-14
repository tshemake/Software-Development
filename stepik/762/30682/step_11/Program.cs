using System;

/*
 * Вычислите сумму ряда чисел от a до b. Например от 1 до 10:
 * sum = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 +10
 *
 * Числа a и b будут переданы строкой на stdin, и разделены пробелом.
 * Ответ необходимо вывести в stdout.
 *
 * Вызов встроенных командных оболочек из скрипта невозможен.
 *
 * Sample Input:
 *
 *  11 97
 * Sample Output:
 *
 *  4698
 */

namespace step_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arguments = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int a = Int32.Parse(arguments[0]);
            int b = Int32.Parse(arguments[1]);
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
