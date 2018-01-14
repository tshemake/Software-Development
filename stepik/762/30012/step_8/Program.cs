using System;
using System.Text.RegularExpressions;

/*
 * Напишите результат выполнения команды:
 *
 *  box@de98796:~$ echo Заморский | sed 's/За/При/'
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("За");
            Console.WriteLine(regex.Replace("Заморский", "При", 1));
        }
    }
}
