using System;

/*
 * Скачайте файлы, необходимые для запуска bowtie2: референсный
 * геном (reference) и риды (reads). Запустите программу bowtie2
 * на этих данных (напоминаем, что запуск состоит из двух этапов!).
 * Вывод stderr второго этапа (т.е. запуск подпрограммы bowtie2)
 * запишите в файл (см. занятие про перенаправление ввода/вывода)
 * и загрузите его в форму ниже. Мы также рекомендуем вам
 * перенаправлять вывод stdout в файлы на обоих этапах, чтобы он
 * не засорял экран вашего терминала.
 *
 * Попробуйте теперь запустить второй этап (запуск подпрограммы
 * bowtie2) в несколько потоков. Рекомендуем выставить число потоков
 * равное количеству ядер на вашем компьютере (команда nproc).
 * Сравните скорость выполнения в таком режиме с работой в один
 * поток. Также рекомендуем убедиться, что результаты запусков
 * (т.е. вывод в stderr) полностью совпали в обоих режимах!
 *
 * Примечание: если у вас не очень сильный компьютер, то работа
 * bowtie2 на предложенных данных может занять достаточно
 * продолжительное время. Если вы не хотите ждать, то можете
 * использовать альтернативные (сильно уменьшенные) версии референсного
 * генома (reference) и ридов (reads). На этих данных у вас не
 * получится увидеть разницу в скорости при запуске в один или в
 * несколько потоков, но вы сможете выполнить все остальные пункты
 * задания и получить за него полный балл.
 */

namespace step_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wget -O bowtie2-2.1.0-linux-x86_64.zip https://stepik.org/media/attachments/course73/programs/bowtie2-2.1.0-linux-x86_64.zip");
            Console.WriteLine("unzip owtie2-2.1.0-linux-x86_64.zip");
            Console.WriteLine("cd owtie2-2.1.0");
            Console.WriteLine("wget -O reference.fasta https://stepik.org/media/attachments/course73/reference.fasta");
            Console.WriteLine("wget -O reads.fastq.gz https://stepik.org/media/attachments/course73/reads.fastq.gz");
            Console.WriteLine("gunzip reads.fastq.gz");
            Console.WriteLine("./bowtie2-build reference.fasta index >> bowtie2.log 2>> bowtie2.log");
            Console.WriteLine("./bowtie2 -x index -U reads.fastq -p 4 >> bowtie2.log 2>> result.log");
        }
    }
}
