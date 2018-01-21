using System;

/*
 * Выборочное пространство
 * \Omega = \left\{ {{\omega _1},{\omega _2},{\omega _3}} \right\}, P({\omega _2}) = 1/3, P({\omega _3}) = 1/2.
 * Чему равняется вероятность элементарного события {\omega _1}?
 * Введите число в виде десятичной дроби с разделителем точка с
 * точностью до трех десятичных знаков, например, 0.357.
 *  P({\omega _1}) =
 */
 
namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:0.000}", 1 - 1d / 3 - 1d / 2);
        }
    }
}
