using System;

/*
 * Напишите команду, которая заменит пользователя владельца каталога
 * /home/foo на bar.
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chown bar /home/foo");
        }
    }
}
