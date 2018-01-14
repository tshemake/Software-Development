using System;

/*
 * 1. Разблокируйте учетную запись пользователя foo.
 *
 * 2. Заблокируйте учетную запись пользователя bar.
 *
 * 3. Задайте срок действия учетной записи пользователя foo -
 * 1 апреля 2019 года.
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sudo usermod -U foo");
            Console.WriteLine("sudo usermod -L bar");
            Console.WriteLine("sudo chage -E 2019-04-01 foo");
        }
    }
}
