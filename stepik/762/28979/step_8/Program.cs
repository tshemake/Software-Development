using System;

/*
 * Проверьте с помощью type и which, какие команды являются
 * встроенными в командную оболочку, а какие внешними:
 *
 *     * alias
 *     * echo
 *     * rm
 *     * route
 *     * tac
 *     * which
 * Проверьте с помощью which в каких директориях находятся бинарные
 * файлы внешних команд.
 * Запишите или запомните результат.
 */

namespace step_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type -a alias # alias is a shell builtin");
            Console.WriteLine("which alias # which: no alias in ($PATH)");
            Console.WriteLine("type -a echo # echo is a shell builtin; echo is /bin/echo");
            Console.WriteLine("which echo # /bin/echo");
            Console.WriteLine("type rm # rm is /bin/rm");
            Console.WriteLine("which rm # /bin/rm");
            Console.WriteLine("type route # route is /sbin/route");
            Console.WriteLine("which route # /sbin/route");
            Console.WriteLine("type tac # tac is /usr/bin/tac");
            Console.WriteLine("which tac # /usr/bin/tac");
            Console.WriteLine("type which # which is /usr/bin/which; which is /bin/which");
            Console.WriteLine("which which # /usr/bin/which");
        }
    }
}
