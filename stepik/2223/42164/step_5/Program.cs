﻿using System;

/*
 * Для начала - небольшой тест!
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Замыкание хранит ссылку на переменные, находящиеся в функции, внешней по отношению к ней");
            Console.WriteLine("Если внутри обычной функции, вложенной в другую функцию, сделать обращение к переменной, находящейся во внешней функции, то она будет называться замыканием");
            Console.WriteLine("Если внутри обычной функции, вложенной в другую функцию, сделать обращение к входному параметру внешней функции, то она будет называться замыканием");
        }
    }
}
