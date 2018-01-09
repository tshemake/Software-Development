using System;
using System.Numerics;

/*
 * Составьте выражение для вычисления в интерпретаторе Python 3 и
 * вставьте в поле ответа результат вычисления:
 * 2014^{14}
 *
 * Заметьте, насколько большое это число. Во многих других языках
 * программирования работать со значениями такого порядка гораздо сложнее.
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BigInteger.Pow(2014, 14));
        }
    }
}
