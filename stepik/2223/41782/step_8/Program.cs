﻿using System;

/*
 * В этом задании вам нужно вписать в указанное место код, который
 * будет присваивать переменной "х" название цифры, переданной в
 * переменную "а". Цифра в переменную "а" будет передана случайным
 * образом и может оказаться в диапазоне от 0 до 9, название должно
 * быть написано по-русски с большой буквы - "Один", "Два" и т.д.
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testCase(8));
        }

        private static string testCase(double a)
        {
            string x = null;
            switch (a)
            {
                case 0:
                    x = "Ноль";
                    break;
                case 1:
                    x = "Один";
                    break;
                case 2:
                    x = "Два";
                    break;
                case 3:
                    x = "Три";
                    break;
                case 4:
                    x = "Четыре";
                    break;
                case 5:
                    x = "Пять";
                    break;
                case 6:
                    x = "Шесть";
                    break;
                case 7:
                    x = "Семь";
                    break;
                case 8:
                    x = "Восемь";
                    break;
                case 9:
                    x = "Девять";
                    break;
            }
            return x;
        }
    }
}
