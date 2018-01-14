using System;

/*
 *  #!/bin/bash
 *  a=3
 *  b=4
 *  if [ $a -lt $b ]
 *  then
 *    let c=b-a
 *  else 
 *   let c=a+b
 *  fi
 *  echo $c
 * Какое число будет выведено на экран в результате выполнения скрипта?
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int c;
            if (a < b)
            {
                c = b - a;
            }
            else
            {
                c = a + b;
            }
            Console.WriteLine(c);
        }
    }
}
