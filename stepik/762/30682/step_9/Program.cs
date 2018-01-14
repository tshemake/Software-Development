using System;

/*
 * Нужно завершить цикл while, как только $i превысит 11.
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"#!/bin/bash
i=1
while [ $i -le 11 ]
do
    let i=i+1
done");
        }
    }
}
