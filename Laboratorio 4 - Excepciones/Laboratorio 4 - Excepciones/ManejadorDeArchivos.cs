using System;
using System.Collections.Generic;
using System.IO;

namespace Laboratorio_4___Excepciones
{
    public class ManejadorDeArchivos
    {

        public void Escribir(String nomArchivo, String texto)
        {
            StreamWriter writer = new StreamWriter(nomArchivo, true);
            writer.WriteLine(texto);
            writer.Close();
        }

        public List<String> Leer(String nomArchivo)
        {
            StreamReader reader = new StreamReader(nomArchivo);
            List<String> lineasArchivo = new List<String>();
            while (reader.Peek() > -1)
            {
                lineasArchivo.Add(reader.ReadLine());
            }
            reader.Close();
            return lineasArchivo;
        }

    }

}