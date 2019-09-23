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
        private readonly string path;
        public AppLogger(string path)
        {
            this.path = path;
        }
        public void Save()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            else
            {
                throw new Exception("Type new file name");
            }
        }

        public void Write( string text)
        {
            // File.WriteAllBytes(path, new byte[] { 1, 2, 3, 145 });
            File.AppendAllText(path, text);
;        }
        public void Write(string[] text)
        {
            File.AppendAllLines(path, text);
        }
        public void SaveDirecotry(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

    }
}
