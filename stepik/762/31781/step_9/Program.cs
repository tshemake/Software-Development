using System;

/*
 * 1. Создайте группы  tennis, football и sport.
 *
 * 2. Найдите пользователей, которые состоят в группе beer.
 * Удалите их из этой группы и поместите их в группу sport.
 *
 * 3. Делегируйте пользователю baz права на управление группами
 * football и tennis.
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sudo groupadd tennis");
            Console.WriteLine("sudo groupadd football");
            Console.WriteLine("sudo groupadd sport");
            Console.WriteLine("for user in `grep beer /etc/group | cut -d: -f4 | sed -e 's/,/\\n/g'`; do sudo gpasswd -d $user beer; sudo gpasswd -a $user sport; done");
            Console.WriteLine("sudo gpasswd -A baz football");
            Console.WriteLine("sudo gpasswd -A baz tennis");
        }
    }
}
