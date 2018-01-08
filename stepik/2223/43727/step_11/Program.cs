using System;

/*
 * Теперь проверим, насколько понятно был изложен предыдущий материал!
 */

namespace step_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ключевое слово this используется для доступа к объекту, из которого оно вызывается");
            Console.WriteLine("Выполнение кода function Person(name, age, year) { this.name = name;} создаст конструктор для объекта person");
            Console.WriteLine("Если присвоить значению какого-либо свойства код, то мы получим метод");
        }
    }
}
