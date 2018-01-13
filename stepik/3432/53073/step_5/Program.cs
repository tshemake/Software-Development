using System;

/*
 * Now let's see how clearly the material on the methods of the
 * String object working with regular expressions was described.
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The result of the split() method is an array");
            Console.WriteLine("The Replace(regex, str) method supports global search");
            Console.WriteLine("If you pass a string to the Replace and Search methods instead of a regular expression, it will be converted to a regular expression");
        }
    }
}
