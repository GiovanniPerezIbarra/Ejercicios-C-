using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Saludo saludo = new Saludo();
            string nombre;
            nombre = saludo.SolicitarNombre();
            saludo.Saludar(nombre);
        }
       
    }
}
