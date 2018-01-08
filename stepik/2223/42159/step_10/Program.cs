using System;

/*
 * В этом задании в нашу функцию передаются два параметра:
 * целочисленная переменная ("а") и некоторая функция ("func").
 * Вам необходимо запустить функцию "func", с переменной "а" в
 * качестве аргумента. Но вот проблема - в функции, похоже,
 * оказалась ошибка. Вам нужно возвратить имя (свойство "name")
 * возникающей ошибки.
 *
 * Sample Input:
 *
 *  9
 * Sample Output:
 *
 *  EvalError
 */

namespace step_10
{
    class Program
    {
        private delegate double MyFunction(double x);
        static void Main(string[] args)
        {
            Console.WriteLine(testErrorFunc(9, MyFunctionMethod));
        }

        private static double MyFunctionMethod(double x)
        {
            Random rnd = new Random();
            if (rnd.NextDouble() < 0.5)
            {
                throw new Exception();
            }
            return x;
        }

        private static string testErrorFunc(double a, MyFunction func)
        {
            string x = null;
            try
            {
                func(a);
            }
            catch (Exception ex)
            {
                x = ex.GetType().ToString();
            }
            return x;
        }
    }
}
