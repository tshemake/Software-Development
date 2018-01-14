using System;

/*
 * В результате выполнения скрипта
 *
 *  #!/bin/bash
 *  count=11
 *  if [ $count -ge 42 ]
 *  then
 *    echo "Достаточно."
 *  else
 *    echo "Мало."
 *  fi
 *
 * на экран будет выведено
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 11;
            if (count >= 42)
            {
                Console.WriteLine("Достаточно.");
            }
            else
            {
                Console.WriteLine("Мало.");
            }
        }
    }
}
