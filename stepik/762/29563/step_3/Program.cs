using System;

/*
 * В директории /home/box/testdir дан набор тестовых файлов.
 *
 * 1. Выведите в файл ~/answer1 все имена файлов, которые начинаются
 * с testC.
 *
 * 2. Выведите в файл ~/answer2 все имена файлов, которые начинаются
 * с testP и заканчиваются числовым символом.
 *
 * 3. Выведите в файл ~/answer3 все имена файлов, которые начинаются
 * с testM и заканчиваются строчной буквой английского алфавита.
 *
 * Для вывода имен файлов в одноколоночном формате используйте команду
 * ls с аргументом -1 (единица). В ответе ожидается полный абсолютый
 * путь к каждому файлу.
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LANG=C");
            Console.WriteLine("ls /home/box/testdir/testC* > answer1");
            Console.WriteLine("ls /home/box/testdir/testP*[0-9] > answer2");
            Console.WriteLine("ls /home/box/testdir/testM*[a-z] > answer3");
        }
    }
}
