using System;

/*
 * Предположим у вас есть файл data.csv с двумя столбцами по 10
 * чисел в каждом. В первой строке не записаны названия столбцов,
 * т.е. ряды данных начинаются прямо с первой строки. Вы запускаете
 * gnuplot и вводите в него две команды:
 *
 * set key autotitle columnhead
 * plot 'data.csv' using 1:2
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Название -- первое значение из второго столбца, нарисовано 9 точек (точка из первой строки пропущена)");
        }
    }
}
