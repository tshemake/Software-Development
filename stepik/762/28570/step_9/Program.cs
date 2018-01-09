using System;

/*
 * 1. Создайте пустые файлы file1 и file2 в домашней директории.
 *
 * 2. Создайте директорию ~/default, и скопируйте в нее все файлы
 * из /etc/default.
 *
 * 3. Создайте директорию ~/newdir, и переместите в нее файлы
 * rsyslog и syslog-ng из ~/default.
 *
 * 4. Удалите директорию /var/cache/apt со всем поддиректориями и
 * файлами (используйте команду sudo для удаления с правами суперпользователя).
 */

namespace step_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("touch file1 file2");
            Console.WriteLine("mkdir default");
            Console.WriteLine("cp -R /etc/default/. default");
            Console.WriteLine("mkdir newdir");
            Console.WriteLine("mv default/{rsyslog,syslog-ng} newdir");
            Console.WriteLine("sudo rm -rf /var/cache/apt");
        }
    }
}
