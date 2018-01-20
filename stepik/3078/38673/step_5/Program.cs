using System;

/*
 * Чему равно значение переменной x после выполнения следующей
 * программы:
 *
 *  #include <stdio.h>
 *  int main(void){
 *  int n = 2;
 *  double x=0, pi = 3.14;
 *
 *  x = n*pi*x;
 *
 *  return 0;
 *  }
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            double x = 0, pi = 3.14;
            x = n * pi * x;
            Console.WriteLine(x);
        }
    }
}
