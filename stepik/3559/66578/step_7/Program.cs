using System;
using System.Linq;

/*
 * Запишите, что выведет интерактивный интерпретатор языка
 * программирования Питон, выполнив следующее выражение:
 * 'АБВГДЕйка' * 7
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("АБВГДЕйка", 7)));
        }
    }
}
