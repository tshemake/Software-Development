using System;

/*
 * Предположим, что в директории /home/bi/ есть следующая структура
 * файлов и поддиректорий:
 *
 *  /home/bi/
 *  └── dir1
 *      ├── file1 
 *      └── dir2
 *          ├── file2
 *          └── dir3
 *              └── file3
 *
 * Какие(ой) из трех файлов (file1, file2, file3) будут найдены по
 * команде find /home/bi -mindepth 2 -maxdepth 3 -name "file*"?
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Все кроме file3");
        }
    }
}
