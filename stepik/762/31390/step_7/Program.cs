using System;

/*
 * 1. Создайте пользователя user01, с домашней директорией
 * /home/u01d и командной оболочкой по умолчанию Korn shell.
 *
 * 2. Удалите учетные записи пользователей, которые используют
 * командную оболочку C shell.
 *
 * 3. Удалите учетную запись и домашнюю директорию пользователя
 * test02.
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sudo useradd -m -d /home/u01d -s /bin/ksh user01");
            Console.WriteLine("sudo userdel `grep /bin/csh$ /etc/passwd | cut -d: -f1`");
            Console.WriteLine("sudo userdel -r test02");
        }
    }
}
