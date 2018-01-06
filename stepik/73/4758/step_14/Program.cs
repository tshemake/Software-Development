using System;

/*
 * Создайте следующую структуру директорий и файлов в домашней
 * директории (/home/quiz/):
 *
 *  //home/quiz/
 *        └── dir1
 *            ├── dir2
 *            │   ├── dir3
 *            │   ├── file3
 *            │   └── file4
 *            ├── dir4
 *            ├── file1
 *            └── file2
 * То есть file3 лежит внутри dir2, которая лежит в dir1, которая
 * лежит в /home/quiz/ и так далее (например, file1 лежит в dir1).
 * Важно отметить, что dirX – это директории, а fileX – файлы.
 * Обратите внимание, что директорию /home/quiz/ создавать не
 * нужно – она уже есть.
 *
 * Это первое задание, где вам потребуется работа в терминале.
 * Для начала выполнения нажмите кнопку "Open Terminal". Когда вы
 * закончили задание нажмите "Submit" (терминал при этом закрывать
 * не нужно!), система проверит корректность выполнения работы и
 * сообщит вам результат.
 */

namespace step_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mkdir -p dir1/dir2/dir3");
            Console.WriteLine("touch dir1/dir2/file{3,4}");
            Console.WriteLine("mkdir dir1/dir4");
            Console.WriteLine("touch dir1/file{1,2}");
        }
    }
}