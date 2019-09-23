using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppLoggers
{
   public class TaskLoger

    {
        private readonly string path;

        public TaskLoger(string path)
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

        public void CreateDir()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public string Info(Object obj)
        {

            return obj.ToString();
            
        }

    }
}
