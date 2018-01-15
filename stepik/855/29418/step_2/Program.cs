using System;

namespace step_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} - {1}", 32, Convert.ToString(32, 2));
            Console.WriteLine("{0} - {1}", 97, Convert.ToString(97, 2));
            Console.WriteLine("{0} - {1}", 127, Convert.ToString(127, 2));
            Console.WriteLine("{0} - {1}", 100, Convert.ToString(100, 2));
            Console.WriteLine("{0} - {1}", 83, Convert.ToString(83, 2));
        }
    }
}
