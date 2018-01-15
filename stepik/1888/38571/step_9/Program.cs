using System;

/*
 * Когда в школе объявили день вежливости, каждый мальчик из 5А
 * класса поздоровался за руку с каждой девочкой из своего класса.
 * Всего при этом было 77 рукопожатий. Сколько учеников в 5А классе?
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            (int a, int b) = prim(77);
            Console.WriteLine(a + b);
        }

        private static (int, int) prim(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return (i, n / i);
                }
            }

            return (1, n);
        }
    }
}
