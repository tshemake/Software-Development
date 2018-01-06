using System;

/*
 * Необходимо осуществить вход в удаленную систему Linux и выйти
 * из нее. имя пользователя box, пароль box. Подключаемся по
 * localhost. Использовать команды ssh и exit 
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ssh box@localhost");
            Console.WriteLine("exit");
        }
    }
}
