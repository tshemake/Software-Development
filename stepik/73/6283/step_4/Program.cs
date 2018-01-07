using System;

/*
 * Какая команда(ы) установят файлу file.txt права доступа
 * rwxrw-r--, если изначально у него были права r--r--r--. Укажите
 * все верные варианты ответа!
 *
 * Примечание: запись вида команда1; команда2; команда3 означает,
 * что в терминале последовательно выполнились все три команды
 * (сначала команда1, затем команда2 и, наконец, команда3).
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chmod u+wx file.txt; chmod g+w file.txt");
            Console.WriteLine("chmod a+wx file.txt; chmod o-wx file.txt; chmod g-x file.txt");
        }
    }
}
