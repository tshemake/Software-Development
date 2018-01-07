using System;

/*
 * Какой командой можно удалить известный ключ с сервера?
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ssh-keygen -R server");
        }
    }
}
