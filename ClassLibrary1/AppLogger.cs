using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLoggers
{
    public class AppLogger
    {
        public void Save(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            
            
        }
    }
}
