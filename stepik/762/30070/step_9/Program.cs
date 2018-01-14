using System;

/*
 * Редактор vi находится в режиме ввода команд. Заполните пропуски,
 * чтобы заменить строки baz на строки bar начиная с 2 и заканчивая 5
 * строкой файла.
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":2,5 s/baz/bar/g");
        }
    }
}
