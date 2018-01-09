using System;

/*
 * Напишите команду для вывода двух последних строк из файла
 * /etc/fstab
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tail -2 /etc/fstab");
        }
    }
}
