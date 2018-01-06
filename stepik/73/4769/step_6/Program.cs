using System;

/*
 * Как обычно можно вызвать справочную информацию о программе program?
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("help program");
            Console.WriteLine("man program");
            Console.WriteLine("program --help (в некоторых программах бывает еще -help или -h)");
        }
    }
}