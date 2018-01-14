using System;
using System.Text.RegularExpressions;

/*
 * Напишите результат выполнения команды:
 *
 *  box@de98796:~$ echo 01.05.1889 | sed 's|\(..\).\(..\).\(....\)|\2/\1/\3|'
 */

namespace step_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "01.05.1889";
            Console.WriteLine(Regex.Replace(str, "(..).(..).(....)", "$2/$1/$3"));
        }
    }
}
