using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstatusAlumnosADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string opc, menu;
            menu = "\n1. Consultar todos\n2. Consultar solo uno\n3. Agregar\n4. Actualizar\n" +
                   "5. Eliminar\n6. Terminar\n\nElija una opción:";
            ADOEstatus bd = new ADOEstatus();
            while (!salir)
            {
                Console.WriteLine(menu);
                opc = Console.ReadLine();
                if (opc == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Consultar todos:\n");
                    foreach (var i in bd.Consultar())
                    {
                        Console.WriteLine($"id: {i.id}, clave: {i.clave}, nombre: {i.nombre}");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opc == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Consultar solo uno\n\nIngrese el id del estatus:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var item = bd.Consultar(id);
                    Console.WriteLine($"id: {item.id}, clave: {item.clave}, nombre: {item.nombre}");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opc == "3")
                {
                    bool otro = false;
                    while (!otro)
                    {
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("Ingresa la clave del estatus");
                            string clave = Console.ReadLine();
                            Console.WriteLine("Ingresa la descripcion del estatus:");
                            string nombre = Console.ReadLine();
                            Estatus estatus = new Estatus { clave = clave, nombre = nombre };
                            bd.Agregar(estatus);
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
                    try
                    {
                        Console.WriteLine("Actualizar\n\nIngrese el id del estatus a actualizar:");
                        int idest = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa la nueva clave del estatus");
                        string clave = Console.ReadLine();
                        Console.WriteLine("Ingresa la nueva descripcion del estatus:");
                        string nombre = Console.ReadLine();
                        Estatus estatus = new Estatus { id = idest, clave = clave, nombre = nombre };
                        bd.Actualizar(estatus);
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
                    try
                    {
                        Console.WriteLine("Eliminar\n\nIngrese el id del estatus a eliminar:");
                        int id = int.Parse(Console.ReadLine());
                        bd.Eliminar(id);
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