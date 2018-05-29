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
        //ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();
        //readonly string archivo = Console.ReadLine();
        //LeerArchivo l = LeerArchivo.Getinstance().ReadFile();
        LeerArchivo leerArchivo = LeerArchivo.GetInstance();

        public ArchivoNoEncontradoException() : base(error)
        {
            try
            {
                //manejadorDeArchivos.Leer(archivo);
                leerArchivo.ReadFile();
            }
            catch (FileNotFoundException)
            {
                DateTimeNow dateTimeNow = new DateTimeNow(leerArchivo.Archivo, error);
            }
            finally
            {
                Console.WriteLine("Se ejecutó el bloque finally");
            }


            //if (!File.Exists(archivo))
            //{
            //    throw new FileNotFoundException(error);
            //}
        }
    }
}
