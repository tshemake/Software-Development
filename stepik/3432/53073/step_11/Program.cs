using System;
using System.Text.RegularExpressions;

/*
 * In this task, a random string (variable s) is passed to our testRegExp function as
 * the first parameter, and the second is a random substring (variable sub_s) that you
 * want to use as a regular expression pattern. You need to return a string from the
 * function, which will list all matches of the template with the first line separated
 * by semicolons.
 *
 *
 *
 * Sample Input 1:
 *
 *  Anbutdsirbutdbutbutareviewbutobutverman
 *  but
 * Sample Output 1:
 *
 *  but;but;but;but;but;but
 * Sample Input 2:
 *
 *  Insoiposmpossibleappospearanposceconsideposredmr
 *  pos
 * Sample Output 2:
 *
 *  pos;pos;pos;pos;pos
 */

namespace step_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testRegExp("Anbutdsirbutdbutbutareviewbutobutverman", "but"));
            Console.WriteLine(testRegExp("Insoiposmpossibleappospearanposceconsideposredmr", "pos"));
        }

        private static string testRegExp(string s, string sub_s)
        {
            MatchCollection matches = Regex.Matches(s, sub_s);
            string[] array = new string[matches.Count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = sub_s;
            }
            return String.Join(';', array);
        }
    }
}
