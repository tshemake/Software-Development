﻿using System;

/*
 * Вы можете скачать и изучить скрипты, которые мы показали в
 * видеофрагменте: branching2.sh, branching3.sh.
 *
 * Посмотрите на фрагмент bash-скрипта:
 * if [[ $var -gt 5 ]]
 * then
 *   echo "one" 
 * elif [[ $var -lt 3 ]]
 * then
 *   echo "two"
 * elif [[ $var -eq 4 ]]
 * then
 *   echo "three"
 * else
 *   echo "four"
 * fi
 *
 * Какие строки и в какой последовательности он выведет на экран,
 * если сначала этот скрипт запустили задав переменную var=3, а затем
 * запустили еще раз, но уже с var=5.
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сначала four, потом four");
        }
    }
}
