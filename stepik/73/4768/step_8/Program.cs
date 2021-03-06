﻿using System;

/*
 * Сколько памяти занимает остановленное (по Ctrl+Z) многопоточное
 * приложение?
 * Подсказка: если вы не знаете как ответить на этот вопрос, то
 * можете попробовать запустить многопоточное приложение на своем
 * компьютере и посмотреть на результат с помощью команды top. Если вы
 * не знаете примеров таких приложений, то рекомендуем вам ненадолго
 * отложить этот шаг и досмотреть занятие до конца. В следующих
 * видеофрагментах и заданиях будет показан пример многопоточного
 * приложения (программы bowtie2). Тестовые данные для запуска этой
 * программы можно найти в последнем задании этого урока.
 *
 * Подсказка 2: подробнее почитать о значении всей информации,
 * которую выводит top на экран, можно по ссылке
 * http://rus-linux.net/MyLDP/consol/komanda-top-v-linux.html
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Столько, сколько оно потребляло в момент остановки");
        }
    }
}
