using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Archivotxt
    {
        static void MostrarTxt(string txt)
        {
            Console.WriteLine("\n");
            StreamReader sr = new StreamReader(@"C:\Users\Tichs\Desktop\" + txt + ".txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        static void MostrarCSV(string csv)
        {
            Console.WriteLine("\n");
            StreamReader sr = new StreamReader(@"C:\Users\Tichs\Desktop\" + csv + ".csv");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }           
        }
        public void EscribirTxt()
        {
            string archivo;
            int codigo;
            Console.WriteLine("Escriba el nombre del archivo en el que desea escribir:");
            archivo = Console.ReadLine();
            string path = @"C:\Users\Tichs\Desktop\" + archivo + ".txt";
            bool existe = File.Exists(path);
            Console.WriteLine("\n1. UTF7\n2. UTF8\n3. Unicode\n4. UTF32\n5. ASCII\n\nElija una opción de codificación:");
            codigo = Convert.ToInt32(Console.ReadLine());
            if(codigo == 1)
            {
                if(existe == false)
                {
                    Console.WriteLine("\nESTE ES UN ARCHIVO NUEVO");
                    bool salir = false;
                    while (!salir)
                    {
                        Console.WriteLine("\nEscriba su nombre:");
                        string nombre = Console.ReadLine();
                        File.AppendAllText(path, nombre + ", ", Encoding.UTF7);
                        Console.WriteLine("Escriba su primer apellido:");
                        string apellido1 = Console.ReadLine();
                        File.AppendAllText(path, apellido1 + ", ", Encoding.UTF7);
                        Console.WriteLine("Escriba su segundo apellido:");
                        string apellido2 = Console.ReadLine();
                        File.AppendAllText(path, apellido2 + ", ", Encoding.UTF7);
                        Console.WriteLine("Escriba su edad:");
                        string edad = Console.ReadLine();
                        File.AppendAllText(path, edad + ", ", Encoding.UTF7);
                        Console.WriteLine("Escriba su estado de origen:");
                        string estado = Console.ReadLine();
                        File.AppendAllText(path, estado + ".\n", Encoding.UTF7);
                        Console.WriteLine("¿Desea agregar otro alumno? (y/n)");
                        string opc = Console.ReadLine();
                        if(opc == "n")
                            salir = true;
                    }
                }
                if (existe == true)
                {
                    Console.WriteLine("\nESTE ARCHIVO EXISTE Y SOLO SE ADICIONARÁN REGISTROS");
                    bool salir = false;
                    while (!salir)
                    {
                        Console.WriteLine("\nEscriba su nombre:");
                        string nombre = Console.ReadLine();
                        File.AppendAllText(path, nombre + ", ", Encoding.UTF7);
                        Console.WriteLine("Escriba su primer apellido:");
                        string apellido1 = Console.ReadLine();
                        File.AppendAllText(path, apellido1 + ", ", Encoding.UTF7);
                        Console.WriteLine("Escriba su segundo apellido:");
                        string apellido2 = Console.ReadLine();
                        File.AppendAllText(path, apellido2 + ", ", Encoding.UTF7);
                        Console.WriteLine("Escriba su edad:");
                        string edad = Console.ReadLine();
                        File.AppendAllText(path, edad + ", ", Encoding.UTF7);
                        Console.WriteLine("Escriba su estado de origen:");
                        string estado = Console.ReadLine();
                        File.AppendAllText(path, estado + ".\n", Encoding.UTF7);
                        Console.WriteLine("¿Desea agregar otro alumno? (y/n)");
                        string opc = Console.ReadLine();
                        if (opc == "n")
                            salir = true;
                    }
                }
            }
            if (codigo == 2)
            {
                if (existe == false)
                {
                    Console.WriteLine("\nESTE ES UN ARCHIVO NUEVO");
                    bool salir = false;
                    while (!salir)
                    {
                        Console.WriteLine("\nEscriba su nombre:");
                        string nombre = Console.ReadLine();
                        File.AppendAllText(path, nombre + ", ", Encoding.UTF8);
                        Console.WriteLine("Escriba su primer apellido:");
                        string apellido1 = Console.ReadLine();
                        File.AppendAllText(path, apellido1 + ", ", Encoding.UTF8);
                        Console.WriteLine("Escriba su segundo apellido:");
                        string apellido2 = Console.ReadLine();
                        File.AppendAllText(path, apellido2 + ", ", Encoding.UTF8);
                        Console.WriteLine("Escriba su edad:");
                        string edad = Console.ReadLine();
                        File.AppendAllText(path, edad + ", ", Encoding.UTF8);
                        Console.WriteLine("Escriba su estado de origen:");
                        string estado = Console.ReadLine();
                        File.AppendAllText(path, estado + ".\n", Encoding.UTF8);
                        Console.WriteLine("¿Desea agregar otro alumno? (y/n)");
                        string opc = Console.ReadLine();
                        if (opc == "n")
                            salir = true;
                    }
                }
                if (existe == true)
                {
                    Console.WriteLine("\nESTE ARCHIVO EXISTE Y SOLO SE ADICIONARÁN REGISTROS");
                    bool salir = false;
                    while (!salir)
                    {
                        Console.WriteLine("\nEscriba su nombre:");
                        string nombre = Console.ReadLine();
                        File.AppendAllText(path, nombre + ", ", Encoding.UTF8);
                        Console.WriteLine("Escriba su primer apellido:");
                        string apellido1 = Console.ReadLine();
                        File.AppendAllText(path, apellido1 + ", ", Encoding.UTF8);
                        Console.WriteLine("Escriba su segundo apellido:");
                        string apellido2 = Console.ReadLine();
                        File.AppendAllText(path, apellido2 + ", ", Encoding.UTF8);
                        Console.WriteLine("Escriba su edad:");
                        string edad = Console.ReadLine();
                        File.AppendAllText(path, edad + ", ", Encoding.UTF8);
                        Console.WriteLine("Escriba su estado de origen:");
                        string estado = Console.ReadLine();
                        File.AppendAllText(path, estado + ".\n", Encoding.UTF8);
                        Console.WriteLine("¿Desea agregar otro alumno? (y/n)");
                        string opc = Console.ReadLine();
                        if (opc == "n")
                            salir = true;
                    }
                }
            }
            if (codigo == 3)
            {
                if (existe == false)
                {
                    Console.WriteLine("\nESTE ES UN ARCHIVO NUEVO");
                    bool salir = false;
                    while (!salir)
                    {
                        Console.WriteLine("\nEscriba su nombre:");
                        string nombre = Console.ReadLine();
                        File.AppendAllText(path, nombre + ", ", Encoding.Unicode);
                        Console.WriteLine("Escriba su primer apellido:");
                        string apellido1 = Console.ReadLine();
                        File.AppendAllText(path, apellido1 + ", ", Encoding.Unicode);
                        Console.WriteLine("Escriba su segundo apellido:");
                        string apellido2 = Console.ReadLine();
                        File.AppendAllText(path, apellido2 + ", ", Encoding.Unicode);
                        Console.WriteLine("Escriba su edad:");
                        string edad = Console.ReadLine();
                        File.AppendAllText(path, edad + ", ", Encoding.Unicode);
                        Console.WriteLine("Escriba su estado de origen:");
                        string estado = Console.ReadLine();
                        File.AppendAllText(path, estado + ".\n", Encoding.Unicode);
                        Console.WriteLine("¿Desea agregar otro alumno? (y/n)");
                        string opc = Console.ReadLine();
                        if (opc == "n")
                            salir = true;
                    }
                }
                if (existe == true)
                {
                    Console.WriteLine("\nESTE ARCHIVO EXISTE Y SOLO SE ADICIONARÁN REGISTROS");
                    bool salir = false;
                    while (!salir)
                    {
                        Console.WriteLine("\nEscriba su nombre:");
                        string nombre = Console.ReadLine();
                        File.AppendAllText(path, nombre + ", ", Encoding.Unicode);
                        Console.WriteLine("Escriba su primer apellido:");
                        string apellido1 = Console.ReadLine();
                        File.AppendAllText(path, apellido1 + ", ", Encoding.Unicode);
                        Console.WriteLine("Escriba su segundo apellido:");
                        string apellido2 = Console.ReadLine();
                        File.AppendAllText(path, apellido2 + ", ", Encoding.Unicode);
                        Console.WriteLine("Escriba su edad:");
                        string edad = Console.ReadLine();
                        File.AppendAllText(path, edad + ", ", Encoding.Unicode);
                        Console.WriteLine("Escriba su estado de origen:");
                        string estado = Console.ReadLine();
                        File.AppendAllText(path, estado + ".\n", Encoding.Unicode);
                        Console.WriteLine("¿Desea agregar otro alumno? (y/n)");
                        string opc = Console.ReadLine();
                        if (opc == "n")
                            salir = true;
                    }
                }
            }
            if (codigo == 4)
            {
                if (existe == false)
                {
                    Console.WriteLine("\nESTE ES UN ARCHIVO NUEVO");
                    bool salir = false;
                    while (!salir)
                    {
                        Console.WriteLine("\nEscriba su nombre:");
                        string nombre = Console.ReadLine();
                        File.AppendAllText(path, nombre + ", ", Encoding.UTF32);
                        Console.WriteLine("Escriba su primer apellido:");
                        string apellido1 = Console.ReadLine();
                        File.AppendAllText(path, apellido1 + ", ", Encoding.UTF32);
                        Console.WriteLine("Escriba su segundo apellido:");
                        string apellido2 = Console.ReadLine();
                        File.AppendAllText(path, apellido2 + ", ", Encoding.UTF32);
                        Console.WriteLine("Escriba su edad:");
                        string edad = Console.ReadLine();
                        File.AppendAllText(path, edad + ", ", Encoding.UTF32);
                        Console.WriteLine("Escriba su estado de origen:");
                        string estado = Console.ReadLine();
                        File.AppendAllText(path, estado + ".\n", Encoding.UTF32);
                        Console.WriteLine("¿Desea agregar otro alumno? (y/n)");
                        string opc = Console.ReadLine();
                        if (opc == "n")
                            salir = true;
                    }
                }
                if (existe == true)
                {
                    Console.WriteLine("\nESTE ARCHIVO EXISTE Y SOLO SE ADICIONARÁN REGISTROS");
                    bool salir = false;
                    while (!salir)
                    {
                        Console.WriteLine("\nEscriba su nombre:");
                        string nombre = Console.ReadLine();
                        File.AppendAllText(path, nombre + ", ", Encoding.UTF32);
                        Console.WriteLine("Escriba su primer apellido:");
                        string apellido1 = Console.ReadLine();
                        File.AppendAllText(path, apellido1 + ", ", Encoding.UTF32);
                        Console.WriteLine("Escriba su segundo apellido:");
                        string apellido2 = Console.ReadLine();
                        File.AppendAllText(path, apellido2 + ", ", Encoding.UTF32);
                        Console.WriteLine("Escriba su edad:");
                        string edad = Console.ReadLine();
                        File.AppendAllText(path, edad + ", ", Encoding.UTF32);
                        Console.WriteLine("Escriba su estado de origen:");
                        string estado = Console.ReadLine();
                        File.AppendAllText(path, estado + ".\n", Encoding.UTF32);
                        Console.WriteLine("¿Desea agregar otro alumno? (y/n)");
                        string opc = Console.ReadLine();
                        if (opc == "n")
                            salir = true;
                    }
                }
            }
            if (codigo == 5)
            {
                if (existe == false)
                {
                    Console.WriteLine("\nESTE ES UN ARCHIVO NUEVO");
                    bool salir = false;
                    while (!salir)
                    {
                        Console.WriteLine("\nEscriba su nombre:");
                        string nombre = Console.ReadLine();
                        File.AppendAllText(path, nombre + ", ", Encoding.ASCII);
                        Console.WriteLine("Escriba su primer apellido:");
                        string apellido1 = Console.ReadLine();
                        File.AppendAllText(path, apellido1 + ", ", Encoding.ASCII);
                        Console.WriteLine("Escriba su segundo apellido:");
                        string apellido2 = Console.ReadLine();
                        File.AppendAllText(path, apellido2 + ", ", Encoding.ASCII);
                        Console.WriteLine("Escriba su edad:");
                        string edad = Console.ReadLine();
                        File.AppendAllText(path, edad + ", ", Encoding.ASCII);
                        Console.WriteLine("Escriba su estado de origen:");
                        string estado = Console.ReadLine();
                        File.AppendAllText(path, estado + ".\n", Encoding.ASCII);
                        Console.WriteLine("¿Desea agregar otro alumno? (y/n)");
                        string opc = Console.ReadLine();
                        if (opc == "n")
                            salir = true;
                    }
                }
                if (existe == true)
                {
                    Console.WriteLine("\nESTE ARCHIVO EXISTE Y SOLO SE ADICIONARÁN REGISTROS");
                    bool salir = false;
                    while (!salir)
                    {
                        Console.WriteLine("\nEscriba su nombre:");
                        string nombre = Console.ReadLine();
                        File.AppendAllText(path, nombre + ", ", Encoding.ASCII);
                        Console.WriteLine("Escriba su primer apellido:");
                        string apellido1 = Console.ReadLine();
                        File.AppendAllText(path, apellido1 + ", ", Encoding.ASCII);
                        Console.WriteLine("Escriba su segundo apellido:");
                        string apellido2 = Console.ReadLine();
                        File.AppendAllText(path, apellido2 + ", ", Encoding.ASCII);
                        Console.WriteLine("Escriba su edad:");
                        string edad = Console.ReadLine();
                        File.AppendAllText(path, edad + ", ", Encoding.ASCII);
                        Console.WriteLine("Escriba su estado de origen:");
                        string estado = Console.ReadLine();
                        File.AppendAllText(path, estado + ".\n", Encoding.ASCII);
                        Console.WriteLine("¿Desea agregar otro alumno? (y/n)");
                        string opc = Console.ReadLine();
                        if (opc == "n")
                            salir = true;
                    }
                }
            }
            Console.WriteLine("\nCONTENIDO DEL ARCHIVO:\n");
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void Presentacion()
        {
            string archivotxt, archivocsv;
            Console.WriteLine("Ingrese el nombre del archivo txt que desee leer:");
            archivotxt = Console.ReadLine();
            MostrarTxt(archivotxt);
            Console.WriteLine("\nIngrese el nombre del archivo csv que desee leer:");
            archivocsv = Console.ReadLine();
            MostrarCSV(archivocsv);
            Console.ReadKey();
            Console.Clear();
        }
    }
}