using System;

/*
 * Сопоставьте команды и результат их выполнения, если вывод
 * команды history 5 следующий:
 *
 * $ history 5
 *  52  ls -l
 *  53  ls
 *  54  df -h | grep sda
 *  55  echo  Ответом на вопросы о смысле жизни, вселенной и всем сущем является 42
 *  56  history 5
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!d - history 5");
            Console.WriteLine("Ctrl+R 42 - ls -l");
            Console.WriteLine("!52 - Ответом на вопросы о смысле жизни, вселенной и всем сущем является 42");
            Console.WriteLine("!! - df -h");
        }
    }
}
