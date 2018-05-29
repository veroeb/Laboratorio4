using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4___Excepciones
{
    public class LeerArchivo
    {
        public string Archivo { get; set; }
        public void ReadFile()
        {
            Console.WriteLine("Ingrese la ruta del archivo:");
            ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();
            Archivo = Console.ReadLine();
            manejadorDeArchivos.Leer(Archivo);
        }
    }
}
