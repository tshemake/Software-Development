using System;

/*
 * In this task, the string (variable str) is passed to our testStr
 * function as the first parameter, and the second parameter is a
 * number (variable n). You need to return from the function a string
 * character, the ordinal number of which is specified in the number
 * transferred to the function.
 *
 * Warning: the sequence number is not equal to the character index
 * in the string. If in doubt, read the previous steps.
 * Sample Input:
 *
 *  Amongstasoronherselfchapterenteredcarriedno
 *  1
 * Sample Output:
 *
 *  A
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testStr("Amongstasoronherselfchapterenteredcarriedno", 1));
        }

        private static char testStr(string str, int n)
        {
            return str[n - 1];
        }
    }
}
