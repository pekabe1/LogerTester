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
         #region 
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
        public void Save(string path)
        {
            path = this.path;
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
            for (int i = 0; i < 5; i++)
            {
                string path = Path.Combine(dir, $"{i}.txt");
                Save(path);
            }
        }

        public void RemoveFile(string path = null)

        {
            if (path != null)
            {
                File.Delete(path);
                return;
            }
            File.Delete(this.path);
        }
        public void Info(string text)
        {

        }
        

        //info warkinng error data/czas


    }
}
