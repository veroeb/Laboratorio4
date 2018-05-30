using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4___Excepciones
{
    public class ArchivoNoEncontradoException : FileNotFoundException
    {
        const string error = "Archivo no encontrado";
        LeerArchivo leerArchivo = LeerArchivo.GetInstance();
        Log log = Log.GetInstance();

        public ArchivoNoEncontradoException() : base(error)
        {
            try
            {
                leerArchivo.ReadFile();
            }
            catch (FileNotFoundException)
            {
                //Log dateTimeNow = new Log(leerArchivo.Archivo, error);
                log.DoLog(error);
            }


            //if (!File.Exists(archivo))
            //{
            //    throw new FileNotFoundException(error);
            //}
        }
    }
}
