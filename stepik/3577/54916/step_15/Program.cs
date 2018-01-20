using System;

/*
 * Переведите число 169 из де­ся­тич­ной си­сте­мы счис­ле­ния в дво­ич­ную.
 * Сколь­ко нулей со­дер­жит по­лу­чен­ное число? В от­ве­те ука­жи­те одно
 * число — ко­ли­че­ство значащих нулей.
 */

namespace step_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString(169, 2).Split('0').Length - 1);
        }
    }
}
