using System;
using System.Linq;

/*
 * In this task, two lines of random length and content are passed
 * to our function testArray. You need to compile one array from the
 * characters of these lines (each character of the string becomes a
 * separate element of the array), then add the first value of the
 * array to the text value "Ivanova", and return all the elements
 * from the function in the reverse order, converting them into a
 * string. 
 * Note that in the reverse order, you need to rearrange the
 * elements inside the array, and you do not need to invert the data
 * inside the elements!
 * Sample Input:
 *
 *  611526 29805338
 * Sample Output:
 *
 *  83350892625116Ivanova
 */

namespace step_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testArray("611526", "29805338"));
        }

        private static string testArray(string a, string b)
        {
            string[] array = new string[a.Length + b.Length + 1];
            a.Select(c => c.ToString()).ToArray().CopyTo(array, 1);
            b.Select(c => c.ToString()).ToArray().CopyTo(array, a.Length + 1);
            array[0] = "Ivanova";
            Array.Reverse(array);
            return string.Join("", array);
        }
    }
}
