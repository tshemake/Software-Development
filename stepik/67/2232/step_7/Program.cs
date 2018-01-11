﻿using System;

/*
 * Коля каждый день ложится спать ровно в полночь и недавно узнал,
 * что оптимальное время для его сна составляет X минут. Коля хочет
 * поставить себе будильник так, чтобы он прозвенел ровно через X
 * минут после полуночи, однако для этого необходимо указать время
 * сигнала в формате часы, минуты. Помогите Коле определить, на какое
 * время завести будильник.
 *
 * Часы и минуты в выводе программы должны располагаться на разных
 * строках (см. пример работы программы)
 *
 * Помните, что для считывания данных нужно вызывать функцию input
 * без аргументов!
 *
 * Sample Input 1:
 *
 *  480
 * Sample Output 1:
 *
 *  8
 *  0
 * Sample Input 2:
 *
 *  512
 * Sample Output 2:
 *
 *  8
 *  32
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());
            int hour = number / 60;
            int min = number % 60;
            Console.WriteLine(hour);
            Console.WriteLine(min);
        }
    }
}
