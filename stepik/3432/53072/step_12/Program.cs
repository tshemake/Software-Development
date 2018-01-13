using System;

/*
 * Match the regular expression to the type of data it matches
 */

namespace step_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date in format DD.MM.YYYY - /([\\d]{2})\\.([\\d]{2}).([\\d]{4})/");
            Console.WriteLine("Post code in Russia - /^\\d{6}$/");
            Console.WriteLine("Internet domain name - /^([0-9a-z]([0-9a-z\\-])*[0-9a-z]\\.)+[a-z]{2,4}$/i");
            Console.WriteLine("e-mail address - /[A-Z0-9._%+-]+@[A-Z0-9-]+.+.[A-Z]{2,4}/igm");
            Console.WriteLine("Color code in hex - /\\#([a-fA-F]|[0-9]){3, 6}/");
            Console.WriteLine("Latitude or Longitude - /-?\\d{1,3}\\.\\d+/");
            Console.WriteLine("Time in format HH:MM:SS - /^([0-1]\\d|2[0-3])(:[0-5]\\d){2}$/");
        }
    }
}
