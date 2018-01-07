using System;

/*
 * Пользователя сильно раздражает необходимость вводить пароль при
 * каждом SSH соединении. Поэтому необходимо авторизоваться с
 * помощью public и private ключей.Используйте ssh-keygen и
 * ssh-copy-id. Пользователь dima, пароль guba. Сервер localhost.
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ssh dima@localhost");
            Console.WriteLine("mkdir .ssh");
            Console.WriteLine("logout");
            Console.WriteLine("ssh-copy-id dima@localhost");
            Console.WriteLine("ssh dima@localhost");
        }
    }
}
