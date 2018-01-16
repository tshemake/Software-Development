using System;

/*
 * 1. Создайте файл ~/testfile, владельцем которого является
 * пользователь foo, и группа bar. Пользователь foo должен иметь
 * права на чтение и запись файла. Члены группы bar - на чтение и
 * выполнение. Остальные - только на выполнение.
 *
 * 2. Создайте директорию ~/testdir, владельцем которой является
 * пользователь baz и группа bar. Пользователь baz должен иметь
 * права на чтение содержимого, вход и создание файлов директории.
 * Члены группы bar - на чтение содержимого и вход. Остальные - на
 * чтение содержимого.
 */

namespace step_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("touch testfile");
            Console.WriteLine("sudo chown foo:bar testfile");
            Console.WriteLine("sudo chmod 651 testfile");
            Console.WriteLine("mkdir -m 754 testdir");
            Console.WriteLine("sudo chown baz:bar testdir");
        }
    }
}
