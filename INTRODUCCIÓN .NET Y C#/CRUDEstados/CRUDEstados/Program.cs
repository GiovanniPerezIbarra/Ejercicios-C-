using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    internal class Program
    {
        private static Dictionary<string, string> _Estados = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            bool salir = false;
            string opc, menu;
            menu = "\n1. Consultar todos\n2. Consultar solo uno\n3. Agregar\n4. Actualizar\n" +
                   "5. Eliminar\n6. Terminar\n\nElija una opción:";
            while (!salir)
            {
                Console.WriteLine(menu);
                opc = Console.ReadLine();
                if (opc == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Consultar todos:\n");
                    foreach (var item in _Estados)
                    {
                        Console.Write(item.Key + ". ");
                        Console.WriteLine(item.Value);
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opc == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Consultar solo uno\n\nIngrese el concepto a consultar (id):");
                    string id = Console.ReadLine();
                    if (_Estados.ContainsKey(id))
                    {
                        Console.WriteLine("Su definicion es: " + _Estados[id]);
                    }
                    else
                    {
                        Console.WriteLine("\nEl concepto no existe.");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opc == "3")
                {
                    bool otro = false;
                    while (!otro)
                    {
                        Console.Clear();
                        Console.WriteLine("Agregar\n\nIngrese el concepto a agregar (id):");
                        string id = Console.ReadLine();
                        if (_Estados.ContainsKey(id))
                        {
                            Console.WriteLine("\nEl concepto ya existe existe.\n");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese su nueva definicion (nombre del estado):");
                            string concepto = Console.ReadLine();
                            _Estados.Add(id, concepto);
                            Console.WriteLine("\nConcepto creado exitosamente.\n");
                        }
                        Console.WriteLine("¿Desea agregar otro concepto? (y/n)");
                        string opcion = Console.ReadLine();
                        if (opcion == "n")
                            otro = true;
                        if (opcion == "N")
                            otro = true;
                    }
                    Console.Clear();
                }

                else if (opc == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Actualizar\n\nIngrese el concepto a actualizar (id):");
                    string id = Console.ReadLine();
                    if (_Estados.ContainsKey(id))
                    {
                        Console.WriteLine("Ingrese su nueva definicion (nombre del estado):");
                        string nuevo = Console.ReadLine();
                        _Estados[id] = nuevo;
                        Console.WriteLine("\nDefinicion actualizada exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("\nEl concepto no existe.");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            
                else if (opc == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Eliminar\n\nIngrese el concepto a eliminar (id):");
                    string id = Console.ReadLine();
                    if (_Estados.ContainsKey(id))
                    {
                        _Estados.Remove(id);
                        Console.WriteLine("\nConcepto eliminado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("\nEl concepto no existe o ya fue eliminado.");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opc == "6")
                    Environment.Exit(-1);
                else
                    Console.WriteLine("\nOpción no encontrada\n");
            }
        }
    }
}
