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
        ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();
        string archivo = @"C:\Users\Vero\Documents\GitHub\Laboratorio4\Laboratorio 4 - Excepciones\hola.txt";

        public ArchivoNoEncontradoException() : base(error)
        {
            try
            {
                manejadorDeArchivos.Leer(archivo);
            }
            catch (FileNotFoundException)
            {
                DateTimeNow dateTimeNow = new DateTimeNow(archivo, error);
            }
            finally
            {
                Console.WriteLine("Se ejecutó el bloque finally");
            }


            //if (!File.Exists(@"C:\Users\Vero\Documents\GitHub\Laboratorio4\Laboratorio 4 - Excepciones\hola.txt"))
            //{
            //    throw new FileNotFoundException(text);
            //}
        }
    }
}
