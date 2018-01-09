using System;

/*
 * Составьте выражение для вычисления указанной ниже формулы и вставьте в поле ответа вывод интерпретатора после вычисления этого выражения.
 *
 * 
 * \dfrac{42}{4 + 2 \cdot (-2)}
 *
 * На самом деле, Python 3 не может вычислить подобное выражение, поэтому возникнет ошибка.
 * Впишите вывод интерпретатора Python 3 в поле для ответа.
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traceback (most recent call last):");
            Console.WriteLine("ZeroDivisionError: division by zero");
        }
    }
}
