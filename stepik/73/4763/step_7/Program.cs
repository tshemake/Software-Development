using System;

/*
 * Для начала выполнения нажмите кнопку "Open Terminal".
 * Открывшийся в браузере терминал будем называть "локальный".
 * Зайдите с этого терминала по SSH на удаленный сервер 10.31.2.1.
 * Для доступа к серверу используйте логин quiz и пароль supersecret.
 * Прочитайте содержимое файла /srv/files_on_server/secret на
 * удалённом сервере и запишите его в локальный файл /home/quiz/secret
 * (т.е. вам нужно будет выйти с сервера!). Для записи данных в файл
 * воспользуйтесь командой:
 *
 * echo "SECRET TEXT" > /home/quiz/secret
 * где вместо SECRET TEXT нужно указать текст из заданного файла.
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ssh quiz@10.31.2.1 \"cat /srv/files_on_server/secret\" > /home/quiz/secret");
        }
    }
}