using System;

/*
 * Необходимо исправить ошибку "Permissions are too open …
 * private key will be ignored". Эта проблема связана с тем, что
 * были изменены права файлов .ssh - 700 и id-rsa - 600. Вам
 * необходимо подключиться к удаленному пользователю nikita,
 * по серверу localhost, который имеет пароль - komp, используя
 * ключ, исправив ошибку, указанную выше, которая будет
 * сгенерирована, автоматически при генерации ключей с
 * использованием команды ssh-keygen (без ключей).  
 * P.S. Необходимо изменить все права на рекомендуемые.
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ssh-keygen");
            Console.WriteLine("chmod 600 .ssh/id_rsa");
            Console.WriteLine("ssh-copy-id nikita@localhost");
            Console.WriteLine("ssh nikita@localhost");
        }
    }
}
