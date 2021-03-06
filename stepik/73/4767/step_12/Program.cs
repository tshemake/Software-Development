﻿using System;

/*
 * Запишите в форму ниже инструкцию sed, которая заменит все
 * "аббревиатуры" в файле input.txt на слово "abbreviation" и
 * запишет результат в файл edited.txt (на экран при этом ничего
 * выводить не нужно). Обратите внимание, что в инструкции должны
 * быть указаны и сам sed, и оба файла!
 *
 * Под "аббревиатурой" будем понимать слово, которое удовлетворяет
 * следующим условиям: 
 *
 * состоит только из больших букв латинского алфавита,
 * состоит из хотя бы двух букв,
 * окружено одним пробелом с каждой стороны.
 * При этом будем считать, что в тексте не может быть две
 * "аббревиатуры" подряд. Например, текст  " YOU YOU and YOU!"
 * является некорректным (в нем есть две "аббревиатуры", но они
 * идут подряд) и на таких примерах мы проверять вашу инструкцию
 * не будем.
 *
 * Пример: если у вас был текст "Hi, I heard these songs by ABBA,
 * TLA and DM !", то он должен быть преобразован в "Hi, I heard these
 * songs by ABBA, abbreviation and abbreviation !".
 *
 * Примечание: после вашей замены "аббревиатуры" на слово
 * "abbreviation" количество пробелов в тексте не должно меняться!
 *
 * Внимание! Во время проверки мы не запускаем команду, которую
 * вы ввели на реальном файле с "аббревиатурами" (это небезопасно,
 * можно же ввести rm -rf /*)! Вместо этого мы сперва анализируем
 * структуру вашей инструкции (например, что в ней использован именно
 * sed и сделано это ровно один раз, что на вход подается input.txt,
 * а результат будет записан в edited.txt и т.д.), а затем запускаем
 * её смысловую часть (т.е. поиск по регулярному выражению и замена
 * на "abbreviation") на тестовых примерах. 
 * К сожалению, наш запуск не идеально повторяет sed, но он очень
 * близок к нему. Главная "несовместимость" заключается в том, что
 * наша проверка не понимает идущие подряд символы, отвечающие за
 * количество повторений (т.е. *, +, ? и {}). Однако эту
 * "несовместимость" легко исправить указав при помощи "(" и ")" какой
 * из символов к чему относится! Например, регулярное выражения а+?
 * (ноль или один раз по одной или более букве "а") нужно записать
 * как (а+)? (при этом запись (а)+?, конечно же, не поможет).
 */

namespace step_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sed -e \"s/\\s[A-Z]\\{2,\\}\\s/ abbreviation /g\" input.txt > edited.txt");
        }
    }
}
