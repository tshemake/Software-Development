﻿using System;

/*
 * Вы можете скачать и изучить скрипты, которые мы показали в
 * видеофрагменте: loops1.sh, loops2.sh.
 *
 * Посмотрите на фрагмент bash-скрипта:
 * for str in a , b , c_d
 * do
 *   echo "start"  
 *   if [[ $str > "c" ]]
 *   then
 *     continue
 *   fi
 *   echo "finish"
 * done
 *
 * Если запустить этот скрипт, то сколько раз на экран будет выведено
 * слово "start", а сколько раз слово "finish"?
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 раз \"start\" и 4 раза \"finish\"");
        }
    }
}
