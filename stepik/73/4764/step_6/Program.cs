using System;

/*
 * Предположим, что вы устанавливаете программу program на свой
 * компьютер при помощи команды sudo apt-get install program.
 * Терминал сообщает вам, что он не может найти и скачать
 * установочный пакет. Какие действия могут устранить проблему?
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка интернет соединения и его установка, если соединения нет.");
            Console.WriteLine("sudo apt-get update");
        }
    }
}