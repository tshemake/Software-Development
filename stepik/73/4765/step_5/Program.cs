﻿using System;

/*
 * Предположим вы запустили программы program1, program2 и program3
 * в фоновом режиме. После этого вы выполнили следующие действия:
 * fg %1
 * Ctrl+С
 * fg %2
 * Ctrl+Z
 * jobs
 *
 * Информация о каких программах будет показана при выполнении команды jobs?
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Только о program2 и program3");
        }
    }
}
