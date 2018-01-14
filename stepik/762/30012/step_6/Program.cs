using System;

/*
 * Содержимое bar.txt:
 *  box@de98796:~$ cat bar.txt
 *  br
 *  bar
 *  baar
 *  baaar
 * Подставьте регулярные выражения, соответствующие результатам
 * выполнения команд:
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("box@de98796:~$ grep -E \"a*\" bar.txt");
            Console.WriteLine("br");
            Console.WriteLine("bar");
            Console.WriteLine("baar");
            Console.WriteLine("baaar");
            Console.WriteLine();
            Console.WriteLine("box@de98796:~$ grep -E \"a+\" bar.txt");
            Console.WriteLine("bar");
            Console.WriteLine("baar");
            Console.WriteLine("baaar");
            Console.WriteLine();
            Console.WriteLine("box@de98796:~$ grep -E 'aaa?' bar.txt");
            Console.WriteLine("baar");
            Console.WriteLine("baaar");
        }
    }
}
