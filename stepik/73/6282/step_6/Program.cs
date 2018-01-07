using System;
using System.Numerics;

/*
 * Напишите скрипт на bash, который принимает на вход один аргумент
 * (целое число от 0 до бесконечности), который будет обозначать
 * число студентов в аудитории. В зависимости от значения числа
 * нужно вывести разные сообщения. 
 *
 * Соответствие входа и выхода должно быть таким:
 * 0 -->  No students
 * 1 -->  1 student
 * 2 -->  2 students
 * 3 -->  3 students
 * 4 -->  4 students
 * 5 и больше --> A lot of students
 * Примечание а): выводить нужно только строку справа, т.е. "-->"
 * выводить не нужно. 
 * Примечание б): в последней строке слово "lot" с маленькой буквы!
 *
 * Примечание 2: в этой и всех последующих задачах на написание
 * скриптов, если не указано явно, что нужно проверять вход (например,
 * что он будет именно числом и именно от 0 до бесконечности), то
 * этого делать не нужно!
 *
 * Пример №1: если ваш скрипт называется ./script.sh, то при запуске
 * его как ./script.sh 1 на экране должно появиться:
 * 1 student
 * Пример №2: если ваш скрипт называется ./script.sh, то при запуске
 * его как ./script.sh 5 на экране должно появиться:
 * A lot of students
 * Подсказка: в случае проблем с решением задачи, обратите внимание
 * на наши рекомендации по написанию скриптов.
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = "No students";
            String[] arguments = Environment.GetCommandLineArgs();
            if (arguments.Length == 2)
            {
                BigInteger numStudents = BigInteger.Parse(arguments[1]);
                if (numStudents < Int32.MaxValue)
                {
                    int num = (int)numStudents;
                    switch (num)
                    {
                        case 0:
                            break;
                        case 1:
                            info = String.Format("{0} student", num);
                            break;
                        case 2:
                        case 3:
                        case 4:
                            info = String.Format("{0} students", num);
                            break;
                        default:
                            info = "A lot of students";
                            break;
                    }
                }
                else
                {
                    info = "A lot of students";
                }
            }
            Console.WriteLine(info);
        }
    }
}
