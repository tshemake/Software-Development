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

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("grep -G \"M\\|W\" tennis.txt");
            Console.WriteLine("grep -E \"W|M\" tennis.txt");
        }
    }
}
