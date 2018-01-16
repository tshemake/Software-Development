using System;

/*
 * 1. Создайте файл ~/summer.txt. Создайте символьную ссылку на этот
 * файл с именем ~/slsummer.txt. 
 *
 * 2. Создайте файл ~/winter.txt. Создайте жесткую ссылку на этот
 * файл с именем ~/hlwinter.txt.
 *
 * 3. Найдите обычный файл с таким же inode, как и у файла ~/findmyhl,
 * который расположен в той же файловой системе. Создайте на него
 * символическую ссылку ~/sl.
 */

namespace step_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("touch summer.txt");
            Console.WriteLine("ln -s summer.txt slsummer.txt");
            Console.WriteLine("touch winter.txt");
            Console.WriteLine("ln winter.txt hlwinter.txt");
            Console.WriteLine("find / -inum $(ls -i findmyhl | cut -d\" \" -f1) 2> /dev/null -exec sh -c '[ \"$1\" != `pwd`/findmyhl ] && ln -s $1 sl' _ {} \\;");
        }
    }
}
