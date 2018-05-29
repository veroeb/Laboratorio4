using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4___Excepciones
{
    public class LeerArchivo
    {
        static LeerArchivo _instance;
        static  ManejadorDeArchivos miManejador;
        public string Archivo { get; set; }
        
        public static LeerArchivo GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LeerArchivo();
                miManejador = new ManejadorDeArchivos();
            }
            return _instance;
        }

        public void ReadFile()
        {
            Console.WriteLine("Ingrese la ruta del archivo:");
            Archivo = Console.ReadLine();
            miManejador.Leer(Archivo);
            Console.WriteLine();
        }
    }
}
