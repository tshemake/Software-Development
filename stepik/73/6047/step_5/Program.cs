using System;

/*
 * Какую опцию нужно указать команде wget, чтобы она не выводила
 * никаких сообщений на экран (Resolving.., Connecting to.. и т.д.)?
 *
 * Подсказка: для ответа на этот вопрос вам понадобится справка по
 * команде wget, которую легко можно получить, набрав man wget.
 */

namespace step_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-q или --quiet");
        }
    }
}