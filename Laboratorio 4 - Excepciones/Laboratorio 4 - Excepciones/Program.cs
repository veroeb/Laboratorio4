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
            ManejadorDeArchivos m = new ManejadorDeArchivos();
            try
            {
                Log.GetInstancia().Escribir("c:/pepe.txt", "Intentando escribir en");
                m.Escribir("c:/pepe.txt", "hola");

            }
            catch (ArchivoNoEncontradoException e)
            {
                Log.GetInstancia().Escribir("c:/pepe.txt", e.Message, ArchivoNoEncontradoException.CantidadVecesExcepcion);
            }

            try
            {
                Log.GetInstancia().Escribir("c:/pepe.txt", "Intentando escribir en");
                m.Escribir("c:/pepe.txt", "hola");

            }
            catch (RutaArchivoInvalidaException e)
            {
                Log.GetInstancia().Escribir("c:/pepe.txt", e.Message, RutaArchivoInvalidaException.CantidadVecesExcepcion);
            }

            Console.ReadKey();
        }
    }
}
