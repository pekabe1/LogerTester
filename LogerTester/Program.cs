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
        
            var logger = new AppLogger(@"D:\Logs");
            //Info
            //Warning
            //Errors
            //2019_09_23_18_23.text
            // zalowoano info

            logger.SaveDirecotry(@"D:\");
            
            logger.Info(@"Zalogownao info...");

            //try
            //{
            //    logger.Warning(@"Zalgowano waring...")
            //}
            //catch (Exception ex)
            //{

            //    logger.Error(ex.Message);
            //}

            Console.Read();
        }
    }
}
