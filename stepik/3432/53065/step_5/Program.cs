using System;

/*
 * Mark all options for the correct function definition
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("function Function(a) { document.write(a); };");
            Console.WriteLine("function myFunction() { };");
            Console.WriteLine("var myFunction = function(a) {document.write(a); } ;");
        }
    }
}
