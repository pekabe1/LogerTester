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
        
            var logger = new AppLogger();
            logger.Save(@"D:\texty.txt");
            Console.Read();

        }
    }
}
