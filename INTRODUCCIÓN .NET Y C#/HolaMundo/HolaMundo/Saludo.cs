using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Saludo
    {
        
        public string SolicitarNombre()
        {
            string nombre;
            Console.WriteLine("¿Cómo te llamas?");
            nombre = Console.ReadLine();
            return nombre;
        }
        public void Saludar(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
            Console.ReadKey();
        }
    }
}
