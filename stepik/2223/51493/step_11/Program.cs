using System;
using System.Text.RegularExpressions;

/*
 * В этом задании в нашу функцию testRegExp первым параметром
 * передается случайная строка(переменная s), а вторым - случайная
 * подстрока(переменная sub_s), которую нужно использовать в
 * качестве шаблона регулярного выражения. Вам нужно вернуть из
 * функции строку, в которой будут перечислены через запятую все
 * совпадения шаблона с первой строкой.
 *
 *
 *
 * Sample Input 1:
 *
 *  Andsirdaarrevarariarewbutovearrmararan
 *  ar
 * Sample Output 1:
 *
 *  ar,ar,ar,ar,ar,ar,ar
 * Sample Input 2:
 *
 *  Extremitiyasiifbrieakfaistagreement
 *  i
 * Sample Output 2:
 *
 *  i,i,i,i,i,i
 */

namespace step_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testRegExp("Andsirdaarrevarariarewbutovearrmararan", "ar"));
            Console.WriteLine(testRegExp("Extremitiyasiifbrieakfaistagreement", "i"));
        }

        private static string testRegExp(string s, string sub_s)
        {
            MatchCollection matches = Regex.Matches(s, sub_s);
            string[] array = new string[matches.Count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = sub_s;
            }
            return String.Join(',', array);
        }
    }
}
