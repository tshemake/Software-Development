using System;

/*
 * Выберите верные утверждения для вывода команды:
 *  paul@laika:~/perms$ ls -l permissions
 *  -rwxr-xr-- 1 paul paul 0 2007-02-07 22:34 permissions
 */

namespace step_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("пользователь-владелец имеет полный доступ к permissions");
            Console.WriteLine("permissions - это файл");
            Console.WriteLine("пользователи, не являющиеся владельцами, и не являющие членами группы владельца, имеют права на чтение permissions");
            Console.WriteLine("группа-владелец имеет права на чтение и исполнение permissions");
        }
    }
}
