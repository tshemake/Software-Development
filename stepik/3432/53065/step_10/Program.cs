using System;

/*
 * Difficult task*
 *
 * Given a natural number n. Write a recursive function that returns
 * a string of numbers from 1 to n separated by a space.
 *
 *
 *
 * The main difficulty of the problem is that it must be solved
 * using recursion. In addition to the Stepik platform, other
 * students will check your decision, using a review mechanism.
 *
 * To get the maximum score for the task, you need to meet the
 * following conditions:
 * 
 * It is correct to solve the problem (make sure that the task
 * is highlighted in green)
 * Make sure once again that the problem is solved with the help
 * of recursion (this is the only criterion by which you will be
 * judged by other students)
 * Use the button "Send this solution for review". Attention! You
 * can send the decision for a review only once!
 * Check the decisions of at least three other students.
 * Wait until your decision is verified.
 * Sample Input 1:
 *
 *  5
 * Sample Output 1:
 *
 *  1 2 3 4 5
 * Sample Input 2:
 *
 *  7
 * Sample Output 2:
 *
 *  1 2 3 4 5 6 7
 */

namespace step_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(my_function(5));
            Console.WriteLine(my_function(7));
        }

        private static string my_function(int n) => (n > 1 ? my_function(n - 1) + " " : "") + n;
    }
}
