using System;

/*
 * Необходимо отсортировать содержимое tennis.txt по второму
 * столбцу.
 *
 *  box@de98796:~$ cat tennis.txt
 *  Amelie Mauresmo, Fra
 *  Kim Clijsters, BEL
 *  Justine Henin, Bel
 *  Serena Williams, usa
 *  Venus Williams, USA
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sort -k2 tennis.txt");
        }
    }
}
