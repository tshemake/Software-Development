using System;

/*
 * Предположим программа ssh-keygen создала вам два ключа:
 * id_rsa и id_rsa.pub. Какой из этих ключей можно без опаски
 * пересылать по интернету?
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("id_rsa.pub");
        }
    }
}