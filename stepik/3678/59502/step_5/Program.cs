using System;

/*
 * Необходимо удалить 3 строчку в файле /home/vasya/remote_file.txt.
 * Пользователь vasya, пароль vasya, сервер localhost.
 *
 * Подсказка: наиболее простой способ решения данной задачи
 * предполагает использование vim.
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ssh vasya@localhost 'sed 3d -i /home/vasya/remote_file.txt'");
        }
    }
}
