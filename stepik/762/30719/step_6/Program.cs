using System;

/*
 * Программа должна проверить количество переданных аргументов, а
 * также последовательно вывести переданные аргументы.
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"#!/bin/bash
if [ $# -gt 0 ]
then
    while (( $# ))
    do
        echo $1
        shift
    done
fi");
        }
    }
}
