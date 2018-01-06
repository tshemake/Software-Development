using System;

/*
 * Откройте терминал нажатием "Open Terminal"
 * Скачайте в нем архив
 * https://stepik.org/media/attachments/course73/quiz_archive.tar.gz
 * в директорию /home/quiz (для этого вам пригодится команда wget,
 * см. предыдущее занятие).
 * Распакуйте этот архив с использованием ровно одной команды
 * терминала.
 * Нажмите кнопку "Submit".
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wget -O /home/quiz/quiz_archive.tar.gz https://stepik.org/media/attachments/course73/quiz_archive.tar.gz");
            Console.WriteLine("tar xzf /home/quiz/quiz_archive.tar.gz");
        }
    }
}