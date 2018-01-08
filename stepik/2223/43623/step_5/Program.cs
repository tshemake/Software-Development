using System;

/*
 * В этом задании в нашу функцию testStr первым параметром передается
 * строка (переменная str), а вторым - число (переменная n) . Вам
 * нужно вернуть из функции символ строки , порядковый номер которого
 * указан в переданном в функцию числе.
 *
 * Подсказка: порядковый номер не равен индексу символа в строке.
 * Если есть сомнения - перечитайте предыдущие шаги.
 *
 * Sample Input:
 *
 *  Ithardlycousinmealways
 *  19
 * Sample Output:
 *
 *  w
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testStr("Ithardlycousinmealways", 19));
        }

        private static char testStr(string str, int n)
        {
            return str[n - 1];
        }
    }
}
