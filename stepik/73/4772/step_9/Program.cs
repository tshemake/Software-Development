using System;

/*
 * Предположим, что в текстовом файле записана одна единственная
 * строка:
 * one two three four five
 * и вам нужно преобразовать её в строку
 * three four four four five
 *
 * Какие(ой) из предложенных ниже наборов нажатий клавиш выполнят
 * такое редактирование? В этих наборах нажатие на клавишу Esc
 * обозначается как <Esc> (т.е. знаки "<" и ">" не несут отдельного
 * смысла).
 *
 * Примечание: во всех утверждениях имеется в виду, что мы находимся
 * в редакторе vim, включен нормальный режим работы и курсор находится
 * в самом начале строки.
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("d2wwywPp");
            Console.WriteLine("xxxxxxxxwywPp");
            Console.WriteLine("ddithree four four four five<<Esc>");
        }
    }
}
