using System;

/*
 * В каких случаях количество пробелов между словами foo и bar
 * будет сохранено в результате выполнения команды echo?
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("echo 'foo bar'");
            Console.WriteLine("echo \"foo bar\"");
        }
    }
}
