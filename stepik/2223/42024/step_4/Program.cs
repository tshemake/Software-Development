using System;

/*
 * Сопоставьте простейшие операции, указанные в левом столбце с
 * результатами их вычислений, приведенными в правом. Изначальные
 * значения для всех операций: х=6 и y=3;
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x=y; x = 3; y = 3;");
            Console.WriteLine("x = x + y; x = 9; y = 3;");
            Console.WriteLine("x = y - x; x = -3; y = 3;");
            Console.WriteLine("x = x * y; x = 18; y = 3;");
            Console.WriteLine("x = x % y; x = 0; y = 3;");
            Console.WriteLine("x = x / y; x = 2; y = 3;");
            Console.WriteLine("x = ++y; x = 4; y = 4;");
            Console.WriteLine("x = y++; x = 3; y = 4;");
            Console.WriteLine("x = --y; x = 2; y = 2;");
            Console.WriteLine("x = y--; x = 3; y = 2;");
        }
    }
}
