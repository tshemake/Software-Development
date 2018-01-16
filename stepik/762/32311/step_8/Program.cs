using System;

/*
 * Напишите команду, которая заменит пользователя и группу владельца
 * каталога /home/foo на bar и baz соотвественно.
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chown bar:baz /home/foo");
        }
    }
}
