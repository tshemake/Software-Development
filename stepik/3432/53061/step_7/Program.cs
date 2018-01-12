using System;

/*
 * Let's see how you learned the previous text. Match the
 * expressions on the left and right of the table!
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The declaration \"var x;\" inside the function will create a local variable.");
            Console.WriteLine("Variable declared outside function has visibility for the entire program in which it is declared");
            Console.WriteLine("The expression inside the function name = \"Victor\"; will create a global variable if a variable with that name has not yet been declared");
            Console.WriteLine("Variable created inside the function will be destroyed when the function is closed");
        }
    }
}
