﻿using System;

/*
 * Создайте строку команды, в рамках которой будет исполняться
 * команда rm file55. Ваша строка команды должна выводить строку
 * 'удалось' (кавычки выводить не нужно) в том случае, если файл
 * file55 был удален и строку 'не удалось' в случае возникновения
 * проблем.
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rm file55 && echo 'удалось' || echo 'не удалось'");
        }
    }
}
