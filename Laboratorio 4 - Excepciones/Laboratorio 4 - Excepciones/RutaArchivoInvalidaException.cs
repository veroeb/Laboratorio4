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
        public static Int32 CantidadVecesExcepcion { get; set; }
        public RutaArchivoInvalidaException(String error) : base(error)
        {
            CantidadVecesExcepcion++;
        }
    }
}
