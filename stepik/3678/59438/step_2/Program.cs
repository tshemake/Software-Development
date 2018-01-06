using System;

/*
 * Выберите корректные команды:
 */

namespace step_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scp /home/The\\ Idiot bibl@10.10.0.5:/classics/Dostoevsky/");
            Console.WriteLine("scp /home/ reader@10.10.0.5://Pushkin/poems/Monument");
            Console.WriteLine("scp reader@10.10.0.5:”/Tolstoy/War and Peace” home/novels");
        }
    }
}
