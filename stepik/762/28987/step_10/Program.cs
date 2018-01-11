using System;

/*
 * 1. Создайте переменную $MyVar, и присвойте ей значение
 * 'Hello world!'. Экспортируйте $MyVar в дочерние командные оболочки.
 *
 * 2. Уничтожьте переменную $TestVar.
 *
 * 3. Выполните экспорт переменных окружения в файл ~/environment
 * перед проверкой результата:
 *
 * env > ~/environment
 */

namespace step_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("export MyVar=\"Hello world!\"");
            Console.WriteLine("unset TestVar");
            Console.WriteLine("env > ~/environment");
        }
    }
}
