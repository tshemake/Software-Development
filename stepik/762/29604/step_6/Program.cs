using System;

/*
 * В каких случаях сообщения об ошибках не будут выводиться на экран?
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("find / > allfiles.txt 2> /dev/null");
            Console.WriteLine("find / > allfiles.txt 2>&1");
        }
    }
}
