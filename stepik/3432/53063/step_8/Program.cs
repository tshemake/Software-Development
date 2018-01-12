using System;

/*
 * In this task, you need to write in the specified place the code
 * that will assign the variable "x" the name of the digit transferred
 * to the variable "a". The number in the variable "a" will be
 * transferred randomly and can be in the range from 0 to 9, the name
 * should be written in English with a capital letter - "Zero", "One",
 * "Two", etc.
 * Sample Input:
 *
 *  3
 * Sample Output:
 *
 *  Three
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testCase(3));
        }

        private static string testCase(double a)
        {
            string x = null;
            switch (a)
            {
                case 0:
                    x = "Zero";
                    break;
                case 1:
                    x = "One";
                    break;
                case 2:
                    x = "Two";
                    break;
                case 3:
                    x = "Three";
                    break;
                case 4:
                    x = "Four";
                    break;
                case 5:
                    x = "Five";
                    break;
                case 6:
                    x = "Six";
                    break;
                case 7:
                    x = "Seven";
                    break;
                case 8:
                    x = "Eight";
                    break;
                case 9:
                    x = "Nine";
                    break;
            }
            return x;
        }
    }
}
