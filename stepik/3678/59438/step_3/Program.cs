using System;

/*
 * Необходимо скопировать на удаленный сервер (не переходя на него)
 * локальный текстовый документ с вашего компьютера в папку
 * /home/public, в которой пользователь имеет права на запись.
 * Используйте SCP. Имя пользователя удаленной системы vasya,
 * пароль vasya. Удаленный сервер localhost. Файл pi_course_rools.txt 
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("scp ./pi_course_rools.txt vasya@localhost:/home/public");
        }
    }
}
