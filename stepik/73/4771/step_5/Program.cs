﻿using System;

/*
 * Вы можете скачать и изучить скрипт, который мы показали в видеофрагменте: programs.sh.
 * 
 * Пусть вы находитесь в директории /home/bi/Documents/ и запускаете в ней скрипт следующего содержания:
 *
 *  #!/bin/bash
 * 
 *  cd /home/bi/
 *  echo "`pwd`"
 * Что в этом случае выведет команда echo на экран?
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/home/bi");
        }
    }
}
