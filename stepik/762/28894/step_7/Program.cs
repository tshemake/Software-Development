using System;

/*
 * 1. С помощью утилиты cat создайте файл ~/resolv.conf из файлов
 * head base google1 google2, расположенных в каталоге
 * /etc/resolvconf/resolv.conf.d. Внимание! Сохраняйте
 * последовательность файлов в команде cat, как указано в этом
 * задании.
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cat /etc/resolvconf/resolv.conf.d/{head,base,google1,google2} > resolv.conf");
        }
    }
}
