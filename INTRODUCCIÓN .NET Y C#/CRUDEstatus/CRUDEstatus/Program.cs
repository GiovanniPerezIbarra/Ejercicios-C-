using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    internal class Program
    {
        struct Estatus
        {
            public int id;
            public string name;
            public Estatus(int clave, string nombre)
            {
                id = clave;
                name = nombre;
            }
        }
        private static List<Estatus> _EstatusAlumnos = new List<Estatus>();
        Estatus estatus = new Estatus();
        private Estatus[] array = new Estatus[0];
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
                    foreach (var oEstatus in _EstatusAlumnos)
                    {
                        Console.Write(oEstatus.id + ". ");
                        Console.WriteLine(oEstatus.name);
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opc == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Consultar solo uno\n\nIngrese el concepto a consultar (id):");
                    int id = int.Parse(Console.ReadLine());
                    try
                    {
                        Estatus buscar = _EstatusAlumnos.Find(estatus => estatus.id == id);
                        Console.WriteLine("Su estatus es: " + buscar.name);
                    }
                    catch (KeyNotFoundException)
                    {
                        Console.WriteLine("\nEl estatus no existe.");
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
                        Console.WriteLine("Agregar\n\nIngrese el id del estatus:");
                        int id = int.Parse(Console.ReadLine());
                        try
                        {
                            Console.WriteLine("Ingrese el estatus:");
                            string estatus = Console.ReadLine();
                            _EstatusAlumnos.Add(new Estatus { id = id, name = estatus });
                            Console.WriteLine("\nRegistro realizado exitosamente.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Console.WriteLine("\n¿Desea agregar otro estatus? (y/n)");
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
                    int ides = int.Parse(Console.ReadLine());
                        try
                        {
                            Console.WriteLine("Ingrese el nuevo estatus:");
                            string nuevo = Console.ReadLine();
                            Estatus act = _EstatusAlumnos.Find(status => status.id == ides);
                            act.name = nuevo;
                            Console.WriteLine("\nEl estatus se actualizó correctamente");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opc == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Eliminar\n\nIngrese el concepto a eliminar (id):");
                    int id = int.Parse(Console.ReadLine());
                    try
                    {
                        _EstatusAlumnos.RemoveAll(x => x.id == id);
                        Console.WriteLine("Eliminado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
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