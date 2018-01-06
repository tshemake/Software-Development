using System;

/*
 * Необходимо скопировать текстовый документ c удаленного сервера
 * на ваш компьютер в папку /home/box, который расположен в папке
 * /home/erdos. Используйте SCP. Имя пользователя удаленной системы
 * erdos, пароль erdos. Cервер localhost. Файл block_and_anton.txt.
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scp erdos@localhost:/home/erdos/block_and_anton.txt /home/box");
        }
    }
}
