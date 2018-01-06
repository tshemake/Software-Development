using System;

/*
 * Какая маска команды find НЕ найдет файл Alexey.jpeg?
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*.jpg");
            Console.WriteLine("alexey.*");
            Console.WriteLine("*.?");
        }
    }
}