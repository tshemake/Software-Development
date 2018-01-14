using System;

/*
 * Какие файлы сценариев командной оболочки bash можно использовать
 * для объявления псевдонимов команд, функций и переменных для
 * конкретного пользователя системы?
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~/.profile");
            Console.WriteLine("~/.bash_profile");
            Console.WriteLine("~/.bashrc");
        }
    }
}
