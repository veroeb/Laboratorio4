using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4___Excepciones
{
    public class CaracteresInvalidosException : ArgumentException
    {
        const string error = "Archivo no encontrado";
        LeerArchivo leerArchivo = LeerArchivo.GetInstance();


    }
}
