using System;

/*
 * Какие права доступа заданы для каталога permissions:
 *
 *  paul@laika:~/perms$ ls -l permissions
 *  d-wxr-x--x 1 paul paul 0 2007-02-07 22:34 permissions
 */

namespace step_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,45} {1} {2}", "Вход в директорию", "Изменение содержимого", "Чтение содержимого");
            Console.WriteLine("{0,-36}{1,-20}{2,-21}{3,-9}", "Остальные пользователи", "x", "", "");
            Console.WriteLine("{0,-36}{1,-20}{2,-21}{3,-9}", "Пользователь владелец", "x", "x", "");
            Console.WriteLine("{0,-36}{1,-20}{2,-21}{3,-9}", "Группа владелец", "x", "", "x");
        }
    }
}
