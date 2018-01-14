using System;

/*
 * В директории /home/box/testdir дан набор тестовых файлов.
 * 1. С помощью команды rename измените расширение у тестовых
 * файлов с .text на .txt.
 */

namespace step_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rename 's/.text/.txt/' testdir/*.text");
        }
    }
}
