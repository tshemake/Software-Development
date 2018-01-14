using System;

/*
 * Нужно завершить цикл until, как только j станет меньше 3.
 */

namespace step_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"#!/bin/bash
j=9
until [ $j -lt 3 ]
do
    let j=j-1
done");
        }
    }
}
