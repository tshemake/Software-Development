using System;

/*
 * В этом задании вам нужно вычислить факториал для числа,
 * передаваемого в нашу функцию. На всякий случай напоминаем,
 * что факториал числа a это произведение всех целых чисел от
 * 1 до a, например, если а = 5, то факториал a будет равен 
 * 1 * 2 * 3 * 4 * 5
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testFactorial(5));
            Console.WriteLine(testFactorial(4));
        }

        private static double testFactorial(int a)
        {
            double x = 1;
            for (int i = 1; i <= a; i++)
            {
                x *= i;
            }
            return x;
        }
    }
}
