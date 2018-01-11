using System;

/*
 * Найдите результат выражения для заданных значений a и b.
 * Учитывайте регистр символов при ответе.
 *
 *  a = True
 *  b = False
 *  a and b or not a and not b
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b || !a && !b);
        }
    }
}
