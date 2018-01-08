using System;
using System.Linq;

/*
 * В этом задании в нашу функцию testArray передаются две строки
 * случайной длины и содержания. Вам нужно составить из символов
 * этих строк один массив (каждый символ строки становится отдельным
 * элементом массива), затем добавить первым элементом  массива
 * текстовое значение "Иванов", и вернуть из функции все элементы
 * в обратном порядке, преобразовав в строку. Обратите внимание,
 * что в обратном порядке нужно переставить элементы внутри массива,
 * а данные внутри элементов инвертировать не нужно!
 *
 * Sample Input:
 *
 *  4326 297515
 * Sample Output:
 *
 *  5157926234Иванов
 */

namespace step_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testArray("4326", "297515"));
        }

        private static string testArray(string a, string b)
        {
            string[] array = new string[a.Length + b.Length + 1];
            a.Select(c => c.ToString()).ToArray().CopyTo(array, 1);
            b.Select(c => c.ToString()).ToArray().CopyTo(array, a.Length + 1);
            array[0] = "Иванов";
            Array.Reverse(array);
            return string.Join("", array);
        }
    }
}
