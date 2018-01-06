using System;

/*
 * Cкачайте архив с произведениями Шекспира. Вам нужно сгенерировать
 * файл, в котором будут все строчки из этих произведений, содержащие
 * “love”, и загрузить этот файл в форму.
 *
 * Подсказка: для того, чтобы результаты поиска записались сразу в
 * файл, можно воспользоваться перенаправлением вывода (см. занятие
 * Ввод/Вывод).
 */

namespace step_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wget -O shakespeare.tar.gz https://stepik.org/media/attachments/course73/shakespeare.tar.gz");
            Console.WriteLine("tar -xzf shakespeare.tar.gz");
            Console.WriteLine("grep -r \"love\" Shakespeare/* > result.txt");
        }
    }
}