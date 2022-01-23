using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Arreglos
    {
        public void Cadenas()
        {
            string nombrecompleto;
            Console.WriteLine("Proporciona tu nombre completo:");
            nombrecompleto = Console.ReadLine();
            string[] partesNombre = nombrecompleto.Split(' ');
            Console.WriteLine("\nHola"); 
            Console.WriteLine(partesNombre[0]);
            Console.WriteLine(partesNombre[1]);
            Console.WriteLine(partesNombre[2]);
            Console.WriteLine("\nApellido vertical:");
            char[] letras = partesNombre[1].ToCharArray();
            for(int i = 0; i <= partesNombre[1].Length -1; i++)
            {
                Console.WriteLine(letras[i]);
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void Enteros()
        {
            int mayor=0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                int[] numero = {0, 1, 2, 3, 4};
                numero[i] = int.Parse(Console.ReadLine());
                if (numero[i] > mayor) 
                { 
                    mayor = numero[i]; 
                }
                numero[i] = 0;
            }
            Console.WriteLine("\nEl numero mayor es: " + mayor);
            Console.ReadKey();
            Console.Clear();
        }
        public void ConvierteATipoOracion()
        {
            string oracion, mayus;
            Console.WriteLine("Ingresa una oración cualquiera:");
            oracion = Console.ReadLine();
            string[] partes = oracion.Split(' ');
            for (int i = 0;i < partes.Length; i++)
            {
                mayus = partes[i].Substring(0, 1).ToUpper() + partes[i].Substring(1);
                Console.Write(mayus + " ");
            }   
            Console.ReadKey();
            Console.Clear();
        }
    }
}