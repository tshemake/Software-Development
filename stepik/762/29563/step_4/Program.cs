using System;

/*
 * В директории /home/box/testdir дан набор тестовых файлов.
 *
 * 1. Выведите в файл ~/answer1 все имена файлов, состоящие из 6
 * символов.
 *
 * 2. Выведите в файл ~/answer2 все имена файлов, которые не
 * заканчиваются на английскую букву A.
 *
 * Для вывода имен файлов используйте команду ls с аргументами -f1;
 * указывайте полный абсолютный путь к директории testdir.
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LANG=C");
            Console.WriteLine("ls -f1 /home/box/testdir/?????? > answer1");
            Console.WriteLine("ls -f1 /home/box/testdir/*[!A] > answer2");
        }
    }
}
