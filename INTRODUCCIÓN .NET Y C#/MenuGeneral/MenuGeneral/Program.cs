using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string opc;
            string menu = "\n1.- Método Cadenas - Clase Arreglos\n2.- Método Enteros - Clase Arreglos\n" +
                          "3.- Método ConvierteATipoOracion - Clase Arreglos\n4.- Método Presentación - Clase Poliza\n" +
                          "5.- Manejo de archivos - Clase Archivotxt\n6.- Escribir texto - Clase Archivotxt\n" +
                          "7.- Calculo de Impuesto Sobre la Renta\n8.- Opción 8\nF.- Termina\n\nSeleccione una opción:";
            while (!salir)
            {
                Console.WriteLine(menu);
                opc = Console.ReadLine();
                if (opc == "1")
                {
                    Console.Clear();
                    Console.WriteLine("\nUsted seleccionó la opción 1\n");
                    Arreglos arrays = new Arreglos();
                    arrays.Cadenas();
                }
                else if (opc == "2")
                {
                    Console.Clear();
                    Console.WriteLine("\nUsted seleccionó la opción 2\n");
                    Arreglos arrays = new Arreglos();
                    arrays.Enteros();
                }
                   
                else if (opc == "3")
                {
                    Console.Clear();
                    Console.WriteLine("\nUsted seleccionó la opción 3\n");
                    Arreglos arrays = new Arreglos();
                    arrays.ConvierteATipoOracion();
                }
                else if (opc == "4")
                {
                    Console.Clear();
                    Console.WriteLine("\nUsted seleccionó la opción 4\n");
                    Poliza poliza = new Poliza();
                    poliza.Presentacion();
                }
                    
                else if (opc == "5")
                {
                    Console.Clear();
                    Console.WriteLine("\nUsted seleccionó la opción 5\n");
                    Archivotxt arc = new Archivotxt();  
                    arc.Presentacion();
                }
                    
                else if (opc == "6")
                {
                    Console.Clear();
                    Console.WriteLine("\nUsted seleccionó la opción 6\n");
                    Archivotxt ar = new Archivotxt();
                    ar.EscribirTxt();
                }
                    
                else if (opc == "7")
                {
                    Console.Clear();
                    Console.WriteLine("\nUsted seleccionó la opción 7\n");
                    CalculoISR isr = new CalculoISR();
                    isr.Presentacion();
                }
                    
                else if (opc == "8")
                    Console.WriteLine("\nUsted seleccionó la opción 8\n");
                else if (opc == "F")
                    Environment.Exit(-1);
                else
                    Console.WriteLine("\nOpción no encontrada\n");
            }
            Console.ReadKey();
        }
    }
}
