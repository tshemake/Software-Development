using System;

/*
 * Переведите число из римской системы счисления в десятичную
 * систему счисления.
 *
 * MCMLXV
 */

namespace step_8
{
    class Program
    {
        enum RomanNumeral
        {
            Zero,
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        };
        
        static void Main(string[] args)
        {
            Console.WriteLine(RomanNumeralToNumber("MCMLXV"));
        }

        private static int RomanNumeralToNumber(string roman)
        {
            int result = 0;
            RomanNumeral prev = RomanNumeral.Zero;
            RomanNumeral curr = RomanNumeral.Zero;
            for (int i = roman.Length - 1; i >= 0; i--)
            {
                switch (roman[i])
                {
                    case 'I':
                        curr = RomanNumeral.I;
                        break;
                    case 'V':
                        curr = RomanNumeral.V;
                        break;
                    case 'X':
                        curr = RomanNumeral.X;
                        break;
                    case 'L':
                        curr = RomanNumeral.L;
                        break;
                    case 'C':
                        curr = RomanNumeral.C;
                        break;
                    case 'D':
                        curr = RomanNumeral.D;
                        break;
                    case 'M':
                        curr = RomanNumeral.M;
                        break;
                }
                if (prev > curr)
                {
                    result -= (int)curr;
                }
                else
                {
                    result += (int)curr;
                }
                prev = curr;
            }

            return result;
        }
    }
}
