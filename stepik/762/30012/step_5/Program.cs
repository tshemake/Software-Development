using System;

/*
 * Содержимое файла tennis.txt:
 *  box@de98796:~$ cat tennis.txt
 *  Amelie Mauresmo, Fra
 *  Kim Clijsters, BEL
 *  Justine Henin, Bel
 *  Serena Williams, usa
 *  Venus Williams, USA
 * Нужно найти всех спортсменок из Бельгии.
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("grep -i Bel tennis.txt");
        }
    }
}
