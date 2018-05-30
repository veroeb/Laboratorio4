using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4___Excepciones
{
    //public class Log
    //{
    //    public Log(string archivo, string error)
    //    {
    //        string d = DateTime.Now.ToString();
    //        Console.WriteLine($"[{d}] {error}: {archivo}");
    //    }
    //}

    public class Log
    {
        #region Singleton
        static Log instance;
        public static Log GetInstance()
        {
            if (instance == null) instance = new Log();
            return instance;
        }
        #endregion

        private string path { get; set; }

        public void Init(string logPath) { path = logPath; }

        public void DoLog(string log)
        {
            try
            {
                using (StreamWriter elArchivo = File.AppendText(path))
                {
                    elArchivo.WriteLine(DateTime.Now.ToString($"yyyy-MM-dd HH:mm:ss {log}"));
                    elArchivo.Close();
                }
            }

            catch (Exception) { }
        }

    }
}
