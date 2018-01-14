using System;

/*
 * Сопоставьте параметры с их описанием
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("$$ - идентификатор процесса (PID)");
            Console.WriteLine("$? - последний код завершения процесса");
            Console.WriteLine("$* - строковое представление всех аргументов");
            Console.WriteLine("$1 - первый аргумент");
            Console.WriteLine("$2 - второй аргумент");
            Console.WriteLine("$# - количество аргументов");
        }
    }
}
