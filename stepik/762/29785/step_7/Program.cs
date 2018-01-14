using System;

/*
 * Найти все *.conf файлы, расположенные в директории /etc и
 * скопировать их в /backup (тип файлов -type в команде  указывать
 * не нужно):
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("find /etc -name '*.conf' -exec cp {} /backup \\;");
        }
    }
}
