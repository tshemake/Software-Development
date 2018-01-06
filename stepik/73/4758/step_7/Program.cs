using System;

/*
 * Укажите, какие из следующих команд полностью эквивалентны команде
 * ls -A --human-readable -l /some/directory
 *
 * Подсказка: для правильного ответа на этот вопрос вам может
 * потребоваться справка о команде ls. Напоминаем, что её можно
 * получить с помощью команды man.
 *
 * Подсказка 2: в вопросах с чекбоксами/checkbox может возникнуть
 * ситуация, когда все предложенные варианты ответов являются
 * неверными (варианты каждый раз выбираются случайным образом из
 * большого набора ответов, где есть как верные, так и ложные).
 * В этом случае вы просто не должны отмечать ни один из них
 * (ведь мы просим указывать только верные варианты!) и нажать
 * кнопку "Отправить"/"Submit". Возможна и обратная ситуация,
 * т.е. все предложенные варианты верны. В этом случае отмечаете
 * их всех и нажимаете "Отправить"/"Submit".
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ls -h -A -l /some/directory");
            Console.WriteLine("ls -lAh /some/directory");
            Console.WriteLine("ls --almost-all --human-readable -l /some/directory");
            Console.WriteLine("ls --human-readable -A -l /some/directory");
            Console.WriteLine("ls -Ahl /some/directory");
        }
    }
}