using System;

/*
 * Вы можете скачать и изучить скрипты, которые мы показали в
 * видеофрагменте: script1.sh, script2.sh.
 *
 * Предположим, что вы находитесь в директории /home/bi/Documents/
 * и запускаете в ней скрипт следующего содержания:
 *
 * #!/bin/bash
 *
 * cd /home/bi/
 * touch file1.txt
 * cd /home/bi/Desktop/
 * Как будет выглядеть абсолютный путь до созданного файла file1.txt
 * по окончанию работы скрипта?
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/home/bi/file1.txt");
        }
    }
}
