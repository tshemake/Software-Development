using System;

/*
 * А теперь - задача на... программирование!) 
 * В тексте внизу описана анонимная функция, внутри которой
 * находится замыкание, изменяющее значение переменной во внешней
 * функции и возвращающее ее. Но вот проблема - строчки перепутались
 * местами! Восстановите необходимую последовательность строк.
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("var enumerator = (function () {");
            Console.WriteLine("var actual = 0;");
            Console.WriteLine("return function () {");
            Console.WriteLine("actual++;");
            Console.WriteLine("return actual;");
            Console.WriteLine("}");
            Console.WriteLine("})();");
        }
    }
}
