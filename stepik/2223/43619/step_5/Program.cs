using System;

/*
 * Отметьте все варианты корректного определения функции
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("function myFunction() { };");
            Console.WriteLine("function Function(a) { document.write(a); };");
            Console.WriteLine("var myFunction = function(a) {document.write(a); } ;");
        }
    }
}
