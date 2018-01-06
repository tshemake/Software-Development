using System;

/*
 * Для начала выполнения нажмите кнопку "Open Terminal". Скачайте в
 * открывшемся терминале архив
 * https://stepic.org/media/attachments/course73/byron.txt.gz в
 * директорию /home/quiz и распакуйте его там (для этого вам
 * пригодятся команды wget и gunzip).
 *
 * Откройте в vim файл /home/quiz/byron.txt. Удалите все строки с
 * 1001 по 2000 (включительно). Скопируйте строки с 5 по 11
 * (включительно) и вставьте их в самый конец файла, добавив одну
 * пустую строку перед этой вставкой (т.е. строчка 5 должна следовать
 * за ровно одной пустой строкой, а та за строкой с номером 6277).
 * Замените в тексте все "Harold" на "Ivan".
 *
 * Сохраните отредактированный файл с именем
 * /home/quiz/byron_edited.txt (это можно сделать прямо из vim!).
 */

namespace step_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wget -O byron.txt.gz https://stepik.org/media/attachments/course73/byron.txt.gz");
            Console.WriteLine("gunzip byron.txt.gz");
            Console.WriteLine("vim byron.txt");
            Console.WriteLine(":1001<ENTER>");
            Console.WriteLine("d1000d");
            Console.WriteLine(":5<ENTER>");
            Console.WriteLine("y7y");
            Console.WriteLine("G");
            Console.WriteLine("o<ESC>");
            Console.WriteLine("p");
            Console.WriteLine("gg");
            Console.WriteLine(":%s/Harold/Ivan/gc");
            Console.WriteLine("a");
            Console.WriteLine(":wq! byron_edited.txt");
        }
    }
}
