using System;

/*
 * Сопоставьте команды с выполняемыми функциями
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ -d bar ] - Проверка существования директории bar");
            Console.WriteLine("[ -e bar ] - Проверка существования файла bar");
            Console.WriteLine("[ 'bar' = $bar ] - Сравнение строки bar и значенияе переменной bar");
            Console.WriteLine("[ ЦЕЛОЕ1 -lt $bar ] - ЦЕЛОЕ1 меньше $bar");
            Console.WriteLine("[ ЦЕЛОЕ1 -gt $bar ] - ЦЕЛОЕ1 больше $bar");
            Console.WriteLine("[ ЦЕЛОЕ1 -eq $bar ] - ЦЕЛОЕ1 равно $bar");
            Console.WriteLine("[ ЦЕЛОЕ1 -ne $bar ] - ЦЕЛОЕ1 не равно $bar");
            Console.WriteLine("[СТРОКА1 = СТРОКА2] - Строки совпадают");
            Console.WriteLine("[СТРОКА1 != СТРОКА2] - Строки не совпадают");
        }
    }
}
