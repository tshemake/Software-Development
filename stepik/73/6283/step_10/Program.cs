﻿using System;

/*
 * Впишите в форму ниже максимально короткую команду (т.е. в которой
 * минимально возможное число символов), которая позволит создать в
 * текущей директории 3 поддиректории с именами dir1, dir2, dir3. 
 *
 * Если вы придумали команду, которая выполняет эту задачу, а система
 * проверки сообщает вам "Incorrect"/"Неверно", то скорее всего вы
 * придумали не самую короткую команду из возможных!
 */

namespace step_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mkdir dir{1,2,3}");
        }
    }
}