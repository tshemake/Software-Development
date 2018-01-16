using System;

/*
 * Напишите команду, которая заменит группу владельца каталога
 * /home/foo на bar.
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chgrp bar /home/foo");
        }
    }
}
