using System;
using System.Text.RegularExpressions;

/*
 * Напишите результат выполнения команды:
 *
 * box@de98796:~$ echo послезавтра | sed 's/после/&&/'
 */

namespace step_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "послезавтра";
            Console.WriteLine(Regex.Replace(str, "(после)", "$1$1"));
        }
    }
}
