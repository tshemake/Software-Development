﻿using System;

/*
 * Для каких задач можно использовать удаленный сервер?
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Хранение больших объемов данных");
            Console.WriteLine("Хранение конфиденциальных данных (т.е. доступ к ним должны иметь только ограниченный круг лиц)");
            Console.WriteLine("Выполнение сложных (затратных по памяти и времени) вычислений");
            Console.WriteLine("Хранение общедоступных данных (например, доступных для всех пользователей интернета)");
        }
    }
}