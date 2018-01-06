﻿using System;

/*
 * Надеемся, что вы разобрались, что одну оболочку (например, sh)
 * можно запустить из другой оболочки (например, из bash).
 *
 * Предположим, что вы открыли терминал и у вас в нем запущена
 * оболочка bash. Вы набираете в ней команды А1, А2, А3, а затем
 * запускаете оболочку sh. В этой оболочке вы набираете команды
 * B1, В2, В3 и запускаете оболочку bash. И, наконец, в этой
 * последней оболочке вы набираете команды С1, С2, С3. Если теперь
 * вы попробуете при помощи стрелочек вверх/вниз перемещаться по
 * истории набранных команд, то команды из какого набора(ов) будут
 * появляться?
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Только из набора С");
        }
    }
}
