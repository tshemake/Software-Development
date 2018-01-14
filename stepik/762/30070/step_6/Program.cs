using System;

/*
 * Сопоставьте команды редактора vi и их значение
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":q - завершение работы с редактором");
            Console.WriteLine(":q! - завершение работы с редактором с отклонением внесенных изменений");
            Console.WriteLine(":wq - завершение работы с редактором с сохранением внесенных изменений");
            Console.WriteLine(":n - начать редактирование следующего файла при одновременной работе с множеством файлов");
        }
    }
}
