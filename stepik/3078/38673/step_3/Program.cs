using System;

/*
 * Чему равны значения переменных x,y после выполнения данного
 * куска программы:
 *
 *  int x=2, y=7, t;
 *  t = x;
 *  x = y;
 *  y = t;
 * Попробуйте сначала угадать, а потом проверьте своё предположение.
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 7, t;
            t = x;
            x = y;
            y = t;
            Console.WriteLine("x={0}, y={1}", x, y);
        }
    }
}
