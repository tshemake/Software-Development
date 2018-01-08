using System;

/*
 * Теперь посмотрим, насколько понятно был изложен материал по
 * методам объекта  String, работающим с регулярными выражениями.
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Метод replace(regex, str) поддерживает глобальный поиск");
            Console.WriteLine("Результатом работы метода split() является массив");
            Console.WriteLine("Если в методы replace и search передать вместо регулярного выражения строку, то она будет преобразована в регулярное выражение");
        }
    }
}
