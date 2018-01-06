using System;
using System.Linq;

/*
 * Скачайте файл с программой, сделайте его исполняемым, запустите
 * и скопируйте то, что он выведет на экран, в форму ниже.
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            String currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(currentTime);
            int controlSum = currentTime.ToCharArray().Select(ch => (int)ch).Aggregate(0, (acc, x) => acc + x);
            Console.WriteLine("Control sum: {0}", controlSum);
        }
    }
}

