using System;

/*
 * Вы можете скачать и попробовать применить gnuplot к файлу,
 * который мы показали в видеофрагменте: authors.txt.
 *
 * Какую опцию нужно указать при запуске gnuplot, чтобы при его
 * закрытии не были автоматически закрыты и все нарисованные в
 * нём графики?
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-p, --persist");
        }
    }
}
