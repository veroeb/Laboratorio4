using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4___Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Por favor ingrese la ruta del archivo:");

            ArchivoNoEncontradoException a = new ArchivoNoEncontradoException();

            RutaArchivoInvalidaException r = new RutaArchivoInvalidaException();

            Console.ReadKey();
        }
    }
}
