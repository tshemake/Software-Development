using System;

/*
 * Расставьте строки программы так, чтобы получилась синтаксически
 * правильная программа, после выполнения которой в переменной x
 * будет значение 10, а в переменной y значение 100.
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"#include <stdio.h>
int main (void) {
int x=0, y=0;
x=100;
y = x;
x = 10;
return 0;
}");
        }
    }
}
