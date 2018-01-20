using System;

/*
 * Переведите число 168 из де­ся­тич­ной си­сте­мы счис­ле­ния в дво­ич­ную.
 * Сколь­ко еди­ниц со­дер­жит по­лу­чен­ное число? В от­ве­те ука­жи­те одно
 * число — ко­ли­че­ство единиц.
 */

namespace step_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString(168, 2).Split('1').Length - 1);
        }
    }
}
