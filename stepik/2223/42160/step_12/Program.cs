using System;

/*
 * Сопоставьте регулярное выражение типу данных, которым оно
 * соответствует
 */

namespace step_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дата в формате DD.MM.YYYY - /([\\d]{2})\\.([\\d]{2})\\.([\\d]{4})/");
            Console.WriteLine("Почтовый индекс РФ - /^\\d{6}$/");
            Console.WriteLine("Доменное имя - /^([0-9a-z]([0-9a-z\\-])*[0-9a-z]\\.)+[a-z]{2,4}$/i");
            Console.WriteLine("Адрес электронной почты - /[A-Z0-9._%+-]+@[A-Z0-9-]+\\.[A-Z]{2,4}/igm");
            Console.WriteLine("Код цвета в шестнадцатеричном формате - /\\#([a-fA-F]|[0-9]){3,6}/");
            Console.WriteLine("Широта или долгота - /-?\\d{1,3}\\.\\d+/");
            Console.WriteLine("Время в формате HH:MM:SS - /^([0-1]\\d|2[0-3])(:[0-5]\\d){2}$/");
        }
    }
}
