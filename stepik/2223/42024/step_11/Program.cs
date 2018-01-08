using System;

/*
 * Давайте проверим, насколько понятно был описан материал
 * предыдущего шага!
 */

namespace step_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("При x = 3 и y = 6 результатом операции x < 3 && y == 6 будет false");
            Console.WriteLine("При x = 3 и y = 6 результатом операции !(x > y) будет true");
            Console.WriteLine("При x = 3 и y = 6 результатом операции x == 3 || y > 6 будет true");
        }
    }
}
