using System;

/*
 * Вы можете скачать и изучить скрипт, который мы показали в
 * видеофрагменте: arguments.sh.
 *
 * Напишите скрипт на bash, который принимает на вход два аргумента
 * и выводит на экран строку следующего вида:
 *
 * Arguments are: $1=первый_аргумент $2=второй_аргумент
 *
 * Например, если ваш скрипт называется ./script.sh, то при запуске
 * его ./script.sh one two на экране должно появиться:
 * Arguments are: $1=one $2=two
 * а при запуске ./script.sh three four будет:
 * Arguments are: $1=three $2=four
 * Подсказка: в случае проблем с решением задачи, обратите внимание
 * на наши рекомендации по написанию скриптов.
 */

namespace step_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arguments are: $1={0} $2={1}", args[0], args[1]);
        }
    }
}
