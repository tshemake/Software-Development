using System;

/*
 * Сопоставьте стандартные права доступа к файлам с соответствующими
 * символами
 */

namespace step_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("w - Запись в файл (изменение содержимого директории)");
            Console.WriteLine("x - Запуск файла (просмотр содержимого директории)");
            Console.WriteLine("r - Чтение файла (содержимого директории)");
        }
    }
}
