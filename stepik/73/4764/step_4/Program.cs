using System;

/*
 * Какая команда скопирует на сервер (в домашнюю директорию) папку
 * stepic вместе с содержимым ее самой и всех ее подпапок?
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scp -r stepic username@server:~/");
        }
    }
}