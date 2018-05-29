using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4___Excepciones
{
    public class RutaArchivoInvalidaException : ArgumentNullException
    {
        const string error = "La ruta del archivo es inválida";
        ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();
        string archivo = @"C:\Users\Vero\Documents\GitHub\Laboratorio4\Laboratorio 4 - Excepciones\hola.txt";
    }
}
