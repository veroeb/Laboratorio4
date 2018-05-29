using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4___Excepciones
{
    public class DateTimeNow
    {
        public DateTimeNow(string archivo, string error)
        {
            string d = DateTime.Now.ToString();
            Console.WriteLine($"[{d}] {error}: {archivo}");
        }
    }
}
