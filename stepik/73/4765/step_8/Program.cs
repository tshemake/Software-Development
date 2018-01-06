using System;

/*
 * jobs, top и ps позволяют отслеживать работу запущенных в
 * терминале программ. В каждой из этих трех утилит для каждой
 * запущенной программы указывается число-идентификатор.
 * Одинаковые ли эти идентификаторы в  jobs, top и ps?
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Одинаковые только у ps и top");
        }
    }
}
