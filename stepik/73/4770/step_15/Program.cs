using System;

/*
 * Что произойдет, если запустить процесс в фоновом режиме в одной
 * из вкладок tmux, а затем принудительно закрыть эту вкладку
 * (Ctrl+B, X)?
 */

namespace step_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вкладка закроется, а вместе с ней пропадет и запущенный в ней процесс");
        }
    }
}
