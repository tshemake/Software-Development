using System;

/*
 * Содержимое файла tennis.txt:
 *  box@de98796:~$ cat tennis.txt
 *  Amelie Mauresmo, Fra
 *  Kim Clijsters, BEL
 *  Justine Henin, Bel
 *  Serena Williams, usa
 *  Venus Williams, USA
 * В результате выполнения каких команд будут выведены строки:
 *  Amelie Mauresmo, Fra
 *  Serena Williams, usa
 *  Venus Williams, USA
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("grep -iE 'a$' tennis.txt");
            Console.WriteLine("grep -i a$ tennis.txt");
        }
    }
}
