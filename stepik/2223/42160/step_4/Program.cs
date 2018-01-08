using System;

/*
 * Задача на разминку.
 * Укажите регулярные выражения, которые будут соответствовать
 * какой либо подстроке в строке "http://www.stepik.org";
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/www/");
            Console.WriteLine("/\\//");
            Console.WriteLine("/\\/\\//");
        }
    }
}
