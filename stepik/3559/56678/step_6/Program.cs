﻿using System;

/*
 * Приведены запросы к поисковому серверу. Для каждого запроса
 * указан его код – соответствующая буква от А до Г. Запишите без
 * пробелов коды запросов слева направо в порядке возрастания
 * количества страниц, которые нашёл поисковый сервер по каждому
 * запросу. По всем запросам было найдено разное количество страниц.
 * Для обозначения логической операции «ИЛИ» в запросе используется
 * символ «|», а для логической операции «И» – символ «&».
 * А - [(Java | Python]
 * Б - [Java | Python | C#]
 * В - [(Java & Python) | (Python & C#)]
 * Г - [Java & Python & C#]
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ГВАБ");
        }
    }
}
