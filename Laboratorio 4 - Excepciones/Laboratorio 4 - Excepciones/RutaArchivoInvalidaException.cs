using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4___Excepciones
{
    public class RutaArchivoInvalidaException : DirectoryNotFoundException
    {
        const string error = "La ruta del archivo es inválida";
        LeerArchivo leerArchivo = LeerArchivo.GetInstance();

        public RutaArchivoInvalidaException() : base(error)
        {
            try
            {
                leerArchivo.ReadFile();
            }
            catch (DirectoryNotFoundException)
            {
                DateTimeNow dateTimeNow = new DateTimeNow(leerArchivo.Archivo, error);
            }            
        }
    }
}
