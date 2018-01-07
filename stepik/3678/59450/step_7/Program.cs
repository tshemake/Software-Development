using System;

/*
 * Проверьте корректность прав доступа к файлам ключей сервера
 * sshd; файлы публичных ключей должны читаться любым пользователем,
 * а файлы закрытых ключей - только пользователем root. Файлы
 * ключей находятся  в папке /etc/ssh
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for f in /etc/ssh/ssh_host_*_key; do sudo chmod 600 $f; done");
            Console.WriteLine("for f in /etc/ssh/ssh_host_*_key.pub; do sudo chmod 644 $f; done");
        }
    }
}
