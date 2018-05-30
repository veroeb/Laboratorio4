using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4___Excepciones
{
    public class Log
    {
        private static Log instancia;

        public static Log GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Log();
            }

            return instancia;
        }

        public void Escribir(string archivo, string error, Int32 cantidad)
        {
            string d = DateTime.Now.ToString();
            string texto = $"[{d}] {error}: {archivo}: Cantidad: {cantidad}";
            Console.WriteLine(texto);

            StreamWriter writer = new StreamWriter("C:/Users/Veronica Echezarreta/Desktop/log.txt", true);
            writer.WriteLine(texto);
            writer.Flush();
            writer.Close();

        }

        public void Escribir(string archivo, string error)
        {
            string d = DateTime.Now.ToString();
            string texto = $"[{d}] {error}: {archivo}";
            Console.WriteLine(texto);

            StreamWriter writer = new StreamWriter("C:/Users/Veronica Echezarreta/Desktop/log.txt", true);
            writer.WriteLine(texto);
            writer.Flush();
            writer.Close();

        }

    }

    //public class Log
    //{
    //    #region Singleton
    //    static Log instance;
    //    public static Log GetInstance()
    //    {
    //        if (instance == null) instance = new Log();
    //        return instance;
    //    }
    //    #endregion

    //    private string path { get; set; }

    //    public void Init(string logPath) { path = logPath; }

    //    public void DoLog(string textoALoguear)
    //    {
    //        try
    //        {
    //            using (StreamWriter elArchivo = File.AppendText(path))
    //            {
    //                elArchivo.WriteLine(DateTime.Now.ToString($"yyyy-MM-dd HH:mm:ss {textoALoguear}"));
    //                elArchivo.Close();
    //            }
    //        }

    //        catch (Exception) { }
    //    }

    //}
}
