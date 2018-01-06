using System;

/*
 * Что произойдет, если использовать kill (без опций) по отношению
 * к процессу, который был приостановлен при помощи Ctrl+Z?
 */

namespace step_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Процесс приступит к завершению, как только будет продолжен");
        }
    }
}
