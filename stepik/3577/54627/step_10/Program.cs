using System;
using System.Linq;

/*
 * Запишите в римской системе счисления год создания первого
 * компьютера в СССР.
 */

namespace step_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberToRomanNumeral(1951));
        }

        private static string NumberToRomanNumeral(int number)
        {
            string result = "";
            char[] rom = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            char[] arr = number.ToString().ToCharArray();
            Array.Reverse(arr);
            int pointer = 0;

            for (int i = 0; i < arr.Length; i++, pointer += 2)
            {
                if (Enumerable.Range('0', '3' - '0' + 1).
                    Select(c => (char)c).ToList().
                    Contains(arr[i]))
                {
                    result = new String(rom[pointer], arr[i] - '0') + result;
                }
                else if (arr[i] == '4')
                {
                    result = rom[pointer].ToString() + rom[pointer + 1].ToString() + result;
                }
                else if (Enumerable.Range('5', '8' - '5' + 1).
                    Select(c => (char)c).ToList().
                    Contains(arr[i]))
                {
                    result = rom[pointer + 1].ToString() + new String(rom[pointer], arr[i] - '5') + result;
                }
                else if (arr[i] == '9')
                {
                    result = rom[pointer].ToString() + rom[pointer + 2].ToString() + result;
                }
            }
            return result;
        }
    }
}
