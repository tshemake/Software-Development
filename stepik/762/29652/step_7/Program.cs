using System;

/*
 * 1. Сохраните в файл ~/bashusers отсортированный в алфавитном
 * порядке список имен пользователей из /etc/passwd, которые
 * используют командную оболочку bash.
 * 2. Рассмотрите вывод утилиты /sbin/ifconfig. Создайте команду,
 * с помощью которой будут выводиться исключительно IPv4-адреса.
 * Сохраните результат в файл ~/ipaddr.
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("grep bash /etc/passwd | cut -d: -f1 | sort > ~/bashusers");
            Console.WriteLine("sbin/ifconfig | grep -o 'addr:[0-9]\\{1,3\\}\\.[0-9]\\{1,3\\}\\.[0-9]\\{1,3\\}\\.[0-9]\\{1,3\\}' | sed 's/addr://' > ipaddr");
        }
    }
}
