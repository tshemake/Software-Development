﻿using System;

/*
 * Напишите ответ в двоичном представлении, соответствующий правам доступа
 *  rw-r--r--
 */

namespace step_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Permission("rw-r--r--", 2));
        }

        private static string Permission(string value, int toBase)
        {
            return String.Format("{0}{1}{2}",
                                    Convert.ToString(UserPermission(value), toBase),
                                    Convert.ToString(GroupPermission(value), toBase),
                                    Convert.ToString(OtherPermission(value), toBase));
        }

        private static int UserPermission(string value)
        {
            return RWXToInt(value.Substring(0, 3));
        }

        private static int GroupPermission(string value)
        {
            return RWXToInt(value.Substring(3, 3));
        }
        private static int OtherPermission(string value)
        {
            return RWXToInt(value.Substring(6, 3));
        }

        private static int RWXToInt(string rwx)
        {
            int permission = 0;
            if (char.ToUpperInvariant(rwx[0]) == char.ToUpperInvariant('r'))
            {
                permission += 4;
            }
            else if (rwx[0] == '-')
            {
                permission += 0;
            }
            else
            {
                throw new ArgumentException();
            }
            if (char.ToUpperInvariant(rwx[1]) == char.ToUpperInvariant('w'))
            {
                permission += 2;
            }
            else if (rwx[1] == '-')
            {
                permission += 0;
            }
            else
            {
                throw new ArgumentException();
            }
            if (char.ToUpperInvariant(rwx[2]) == char.ToUpperInvariant('x'))
            {
                permission += 1;
            }
            else if (rwx[2] == '-')
            {
                permission += 0;
            }
            else
            {
                throw new ArgumentException();
            }

            return permission;
        }
    }
}
