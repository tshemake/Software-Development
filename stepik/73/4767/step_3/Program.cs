using System;

/*
 * Пусть в директории /home/bi лежат файлы Star_Wars.avi, star_trek
 * OST.mp3, STARS.txt, stardust.mpeg, Eddard_Stark_biography.txt.
 *
 * Отметьте все файлы, которые найдет команда
 * find /home/bi -iname "star*", но НЕ найдет команда
 * find /home/bi -name "star*"?
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STARS.txt");
            Console.WriteLine("Star_Wars.avi");
        }
    }
}
