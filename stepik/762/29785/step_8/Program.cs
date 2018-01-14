using System;

/*
 * 1. С помощью find найдите все обычные файлы (без директорий,
 * именованных каналов и других файлов специальных типов) с
 * расширением .so, расположенные в директории /lib и во всех ее
 * поддиректориях. Выведите результат в файл ~/libso.
 * 2. С помощью find найдите все обычные файлы с расширением .htm,
 * расположенные в директории /usr/share/doc и во всех ее
 * поддиректориях. Измените расширение на .html для найденных файлов.
 * Выполните поиск и переименование с помощью find одной строкой.
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("find /lib -type f -name '*.so' > libso");
            Console.WriteLine("find /usr/share/doc -type f -name '*.htm' -exec echo \"{}l\" \\;");
        }
    }
}
