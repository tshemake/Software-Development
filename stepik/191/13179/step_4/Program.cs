﻿using System;

/*
 * Что безопаснее: работать под учётной записью с ограниченными
 * правами или под учётной записью администратора?
 */

namespace step_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("с ограниченными правами: злоумышленник не может запустить вредонос или выполнить другие действия без ведома пользователя");
        }
    }
}