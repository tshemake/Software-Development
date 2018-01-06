using System;

/*
 * В каком файле на диске окажется картинка, если для её скачивания
 * были выполнены следующие команды?
 *
 * /cd /home/alex/
 * wget -P /home/alex/Pictures -O 1.jpg http://example.com/example.jpg
 */

namespace step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/home/alex/1.jpg");
        }
    }
}