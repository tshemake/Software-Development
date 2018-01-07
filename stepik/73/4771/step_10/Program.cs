using System;

/*
 * Напишите калькулятор на bash. При запуске ваш скрипт должен
 * ожидать ввода пользователем команды (при этом на экран выводить
 * ничего не нужно). Команды могут быть трех типов: 
 *
 *  1. Слово "exit". В этом случае скрипт должен вывести на экран
 *  слово "bye" и завершить работу. 
 *  2. Три аргумента через пробел -- первый операнд (целое число),
 *  операция (одна из "+", "-", "*", "/", "%", "**") и второй операнд
 *  (целое число). В этом случае нужно произвести указанную операцию
 *  над заданными числами и вывести результат на экран. После этого
 *  переходим в режим ожидания новой команды.
 *  3. Любая другая команда из одного аргумента или из трех аргументов,
 *  но с операцией не из списка. В этом случае нужно вывести на экран
 *  слово "error" и завершить работу.
 * Чтобы проверить работу скрипта, вы можете записать сразу несколько
 * команд в файл и передать его скрипту на stdin (т.е. выполнить
 * ./script.sh < input.txt). В этом случае он должен вывести сразу
 * все ответы на экран.
 *
 * Например, если входной файл будет следующего содержания:
 *  10 + 1
 *  2 ** 10
 *  exit
 * то на экране будет:
 *  11
 *  1024
 *  bye
 *
 * Если же на вход поступит следующий файл:
 *  3 - 5
 *  2/10
 *  exit
 * то на экране будет:
 *  -2
 *  error
 * т.к. вторая команда была некорректной (в ней всего один аргумент,
 * т.к. нет пробелов между числами и операцией, а единственная
 * допустимая команда из одного аргумента это "exit").
 *
 * Подсказка: в случае проблем с решением задачи, обратите внимание
 * на наши рекомендации по написанию скриптов.
 */

namespace step_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            while (true)
            {
                string line = Console.ReadLine();
                string[] arguments = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    if (arguments.Length == 3 &&
                        Int32.TryParse(arguments[0], out a) &&
                        Int32.TryParse(arguments[2], out b))
                    {
                        int result = (int)calculate(a, arguments[1], b);
                        Console.WriteLine(result);
                    }
                    else if (arguments.Length == 1 &&
                             arguments[0] == "exit")
                    {
                        Console.WriteLine("bye");
                        break;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch
                {
                    Console.WriteLine("error");
                    break;
                }
            }
        }

        private static double calculate(int a, string op, int b)
        {
            double result = new double();
            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "%":
                    result = a % b;
                    break;
                case "**":
                    result = Math.Pow(a, b);
                    break;
                default:
                    throw new ArgumentException();
            }

            return result;
        }
    }
}
