﻿using System;

/*
 * Вы можете скачать и изучить скрипты, которые мы показали в
 * видеофрагменте: functions1.sh, functions2.sh.
 *
 * Посмотрите на функцию из bash-скрипта:
 *  counter ()  # takes one argument
 *  {
 *    local let "c1+=$1"
 *    let "c2+=${1}*2"
 *  } 
 *
 * Впишите в форму ниже строку, которую выведет на экран команда
 * echo "counters are $c1 and $c2" если она находится в скрипте
 * после десяти вызовов функции counter с параметрами сначала 1,
 * затем 2, затем 3 и т.д., последний вызов с параметром 10.
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("counters are  and 110");
        }
    }
}
