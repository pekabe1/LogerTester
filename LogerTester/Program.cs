using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AppLoggers;

namespace LogerTester
{
    class Program
    {
        static void Main(string[] args)
        {
        
            var logger = new AppLogger(@"D:\texty.txt");
            //logger.Save();
            string [] text = { "test1", "test2" };
            logger.Write(" Text");
            logger.Write(text);
            logger.Write(" test text IOIOIOIOIIOIOIOOIO");

            Console.Read();

        }
    }
}
