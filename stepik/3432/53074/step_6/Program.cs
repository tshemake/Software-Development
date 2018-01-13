using System;

/*
 * And now - the programming task!)
 * The text below describes an anonymous function inside which is a
 * closure that changes the value of a variable in an external
 * function and returns it. But here's the problem - the lines are
 * messed up in places! Restore the necessary sequence of lines.
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
