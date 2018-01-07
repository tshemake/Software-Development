using System;

/*
 * Необходимо подключиться по ssh, к удаленному пользователю
 * diana по серверу localhost, без ввода пароля или ключевой фразы.
 * Пароль - diana. Используйте ssh-agent(ssh-agent bash, т.к.
 * мы используем bash оболочку) и ssh-add, кроме того, уже известные
 * нам команды - ssh-keygen и ssh-copy-id.
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ssh diana@localhost 'mkdir .ssh'");
            Console.WriteLine("ssh-keygen");
            Console.WriteLine("ssh-copy-id diana@localhost");
            Console.WriteLine("eval `ssh-agent`");
            Console.WriteLine("ssh-add .ssh/id_rsa");
            Console.WriteLine("ssh diana@localhost");
        }
    }
}
