using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Newtonsoft.Json;

namespace LINQ
{
    internal class OperacionesLINQ
    {
        public void Consultas()
        {
            StreamReader archivoAlumno = new StreamReader(@"C:\Users\Tichs\Documents\DESARROLLADOR .NET\INTRODUCCIÓN .NET Y C#\LINQ\Alumnos.json");
            string jsonAlumno = archivoAlumno.ReadToEnd();
            archivoAlumno.Close();
            List<Alumnos> _listAlumno = JsonConvert.DeserializeObject<List<Alumnos>>(jsonAlumno);

            StreamReader archivoEstado = new StreamReader(@"C:\Users\Tichs\Documents\DESARROLLADOR .NET\INTRODUCCIÓN .NET Y C#\LINQ\Estados.json");
            string jsonEstado = archivoEstado.ReadToEnd();
            archivoEstado.Close();
            List<Estado> _listEstado = JsonConvert.DeserializeObject<List<Estado>>(jsonEstado);

            StreamReader archivoEstatus = new StreamReader(@"C:\Users\Tichs\Documents\DESARROLLADOR .NET\INTRODUCCIÓN .NET Y C#\LINQ\Estatus.json");
            string jsonEstatus = archivoEstatus.ReadToEnd();
            archivoEstatus.Close(); 
            List<Estatus> _listEstatus = JsonConvert.DeserializeObject<List<Estatus>>(jsonEstatus);

            StreamReader archivoISR = new StreamReader(@"C:\Users\Tichs\Documents\DESARROLLADOR .NET\INTRODUCCIÓN .NET Y C#\LINQ\TablaISR.csv");
            List<ItemISR> _listISR = new List<ItemISR>();
            var csv = new CsvReader(archivoISR, CultureInfo.InvariantCulture);
            _listISR = csv.GetRecords<ItemISR>().ToList();

            var Estadoid5 = from Estado in _listEstado
                            where Estado.id == 5
                            select Estado;
            Console.WriteLine("\nEstado con id 5:");
            foreach (var item5 in Estadoid5)
            {
                Console.WriteLine($"id: { item5.id}, nombre: { item5.nombre}");
            }

            var Alumno2913 = from Alumnos in _listAlumno
                             where Alumnos.idEstado == 29 || Alumnos.idEstado == 13
                             orderby Alumnos.nombre descending
                             select Alumnos;
            Console.WriteLine("\nAlumnos con idEstado 29 y 13:");
            foreach (var item13 in Alumno2913)
            {
                Console.WriteLine($"id: {item13.id}, nombre: {item13.nombre}, calificacion:" +
                    $" {item13.calificacion}, idEstatus: {item13.idEstatus}, idEstado: {item13.idEstado}");
            }

            var Alumno1920 = from Alumnos in _listAlumno
                              where Alumnos.idEstado == 19 || Alumnos.idEstado == 20
                              && Alumnos.idEstatus == 4 || Alumnos.idEstatus == 5
                              select Alumnos;
            Console.WriteLine("\nAlumnos con idEstado 19 y 20 y idEstatus 4 y 5:");
            foreach (var item20 in Alumno1920)
            {
                Console.WriteLine($"id: {item20.id}, nombre: {item20.nombre}, calificacion:" +
                    $" {item20.calificacion}, idEstatus: {item20.idEstatus}, idEstado: {item20.idEstado}");
            } 

            var Alumnoaprobado = from Alumnos in _listAlumno
                                 where Alumnos.calificacion >= 6
                                 orderby Alumnos.calificacion descending
                                 select Alumnos;
            Console.WriteLine("\nAlumnos con calificacion aprobatoria:");
            foreach (var itemap in Alumnoaprobado)
            {
                Console.WriteLine($"id: {itemap.id}, nombre: {itemap.nombre}, calificacion:" + 
                    $" {itemap.calificacion}, idEstatus: {itemap.idEstatus}, idEstado: {itemap.idEstado}");
            }

            Console.WriteLine("\nCalificacion promedio:");
            Console.WriteLine($"{_listAlumno.Average(a => a.calificacion)}\n");

            foreach (var itemcal in Alumnoaprobado)
            {
                if (itemcal.calificacion >= 6 && itemcal.calificacion <= 7)
                {
                    Console.WriteLine($"Alumno entre 6 y 7: {itemcal.nombre}, calificacion:" +
                        $" {itemcal.calificacion + 2}");
                }
                else if (itemcal.calificacion > 8 && itemcal.calificacion < 10)
                {
                    Console.WriteLine($"Alumno que no tiene 10: {itemcal.nombre}, calificacion: {itemcal.calificacion + 1}");
                }
            }

            var alumnos3 = from Alumnos in _listAlumno
                           where Alumnos.idEstatus == 3
                           join Estados in _listEstado on Alumnos.idEstado equals Estados.id
                           select (Alumnos.id, Alumnos.nombre, Estados.nombre);
            Console.WriteLine("\nAlumnos que tienen estatus 3:");
            foreach( var item3 in alumnos3)
            {
                Console.WriteLine($"{item3}");
            }

            var alumnos2 = from Alumnos in _listAlumno
                           where Alumnos.idEstatus == 2
                           orderby Alumnos.nombre
                           join Estatus in _listEstatus on Alumnos.idEstatus equals Estatus.id
                           select (Alumnos.id, Alumnos.nombre, Estatus.nombre);
            Console.WriteLine("\nAlumnos que tienen estatus 2:");
            foreach (var item2 in alumnos2)
            {
                Console.WriteLine($"{item2}");
            }

            var alumnosmayor2 = from Alumnos in _listAlumno
                           where Alumnos.idEstatus > 2
                           join Estatus in _listEstatus on Alumnos.idEstatus equals Estatus.id
                            join Estados in _listEstado on Alumnos.idEstado equals Estados.id
                            orderby Estatus.nombre
                           select (Alumnos.id, Alumnos.nombre, Estados.nombre, Estatus.nombre);
            Console.WriteLine("\nAlumnos cuyo estatus sea mayor a 2:");
            foreach (var itemayor2 in alumnosmayor2)
            {
                Console.WriteLine(itemayor2);
            }

            var calculoISR = from isr in _listISR
                             where isr.LimInf == 11951.86m && isr.LimSup == 18837.75m
                             select new { sueldoQuincenal = 22000.00m / 2, cuotaf = isr.Cuotafija, 
                             porExce = isr.PorExced, subsidio = isr.Subsidio, 
                             Impuesto = ((((22000.00m / 2) - isr.LimInf) * (isr.PorExced / 100))
                             + isr.Cuotafija) - isr.Subsidio };
            Console.WriteLine("\nCalculo de impuestos en un sueldo mensual de 22,000:");
            foreach (var itemisr in calculoISR)
            {
                Console.WriteLine($"sueldo quincenal: {itemisr.sueldoQuincenal}, cuota Fija: {itemisr.cuotaf}, " +
                    $"porcentaje: {itemisr.porExce}, subsidio: {itemisr.subsidio}," +
                    $" impuesto a pagar: {itemisr.Impuesto}");
            }

        }
    }
}