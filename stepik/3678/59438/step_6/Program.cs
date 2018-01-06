using System;

/*
 * Необходимо сравнить используя ssh и diff два файла
 * /home/box/local_file.txt /home/vasya/remote_file.txt.
 * Пользователь для входа vasya, пароль vasya, сервер localhost.
 * Результат сравнения необходимо занести в файл result.txt,
 * который должен находиться в /home/box.
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ssh vasya@localhost \"cat /home/vasya/remote_file.txt\" | diff - local_file.txt > result.txt");
        }
    }
}
