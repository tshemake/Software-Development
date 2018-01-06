using System;

/*
 * Для начала выполнения нажмите кнопку "Open Terminal".
 * Открывшийся в браузере терминал будем называть "локальный".
 * Скопируйте при помощи SCP с удаленного сервера 10.31.2.1 все
 * файлы из директории /srv/files_on_server/ в локальную директорию
 * /home/quiz/files_on_client/ (её нужно будет еще создать!).
 * Для доступа к серверу используйте логин quiz и пароль supersecret.
 *
 * Примечание: саму директорию files_on_server копировать не нужно!
 * Таким образом, все файлы из неё должны лежать прямо в
 * /home/quiz/files_on_client/.
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mkdir /home/quiz/files_on_client");
            Console.WriteLine("scp -r quiz@10.31.2.1:/srv/files_on_server/* /home/quiz/files_on_client/");
        }
    }
}