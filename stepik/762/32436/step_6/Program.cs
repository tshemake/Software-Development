using System;

/*
 * 1. Создайте группу sports. Поместите в группу sports
 * пользователей foo и bar.
 *
 * 2. Создайте директорию ~/sportsdir, которая будет принадлежать
 * группе пользователей sports.  Члены группы пользователей sports должны иметь возможность создавать файлы в данной директории. Все файлы, создаваемые в данной директории, должны принадлежать группе пользователей sports. Пользователи должны иметь возможность удалять из данной директории только принадлежащие им файлы.
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sudo groupadd sports");
            Console.WriteLine("sudo usermod -a -G sports foo");
            Console.WriteLine("sudo usermod -a -G sports bar");
            Console.WriteLine("mkdir -m g+s,+t sportsdir");
            Console.WriteLine("sudo chgrp sports sportsdir");
        }
    }
}
