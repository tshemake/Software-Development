using System;

/*
 * In this task two parameters are passed to our function: an
 * integer variable ("a") and some function ("func"). You need to
 * run the function "func", with the variable "a" as an argument.
 * But here's the problem - in the function, it seems, there was
 * an error. You need to return the name (the "name" property) of
 * the error that occurs.
 * Sample Input:
 *
 * 9
 * Sample Output:
 *
 * EvalError
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
