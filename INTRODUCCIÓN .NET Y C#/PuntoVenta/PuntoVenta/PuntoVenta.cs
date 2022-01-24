using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class PuntoVenta
    {
        private List<Articulos> _listArticulos = new List<Articulos>();
        private List<ItemBase> _ticket = new List<ItemBase>();
        decimal _totalComisiones, _totalDescuento, _totalVendido, _totalGeneral, _totalVentas;
        public void IniciarVentas()
        {
            StreamReader archivoArticulos = new StreamReader(@"C:\Users\Tichs\Documents\DESARROLLADOR .NET\INTRODUCCIÓN .NET Y C#\PuntoVenta\Articulos.json");
            string jsonArticulos = archivoArticulos.ReadToEnd();
            archivoArticulos.Close();
            _listArticulos = JsonConvert.DeserializeObject<List<Articulos>>(jsonArticulos);
        }
        public void Ventas()
        {
            string opc;
            do
            {
                Venta();
                Console.WriteLine("\n¿Iniciar otra venta o ya terminaste por hoy? (y/n)");
                opc = Console.ReadLine();
            } while (opc == "y");
        }
        private void Venta()
        {
            string agregar;
            do
            {
                Console.WriteLine("\n¿Vas a agregar articulos? (y/n)");
                agregar = Console.ReadLine();
                AgregarArticulo();
            } while (agregar == "y");
            _totalVentas++;
            ImprimirTicket();
        }
        private void AgregarArticulo()
        {
            Console.WriteLine("\nIngrese el id del articulo:");
            int idArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de articulos: ");
            int cantidad = int.Parse(Console.ReadLine());
            Articulos articulo = _listArticulos.Find(x => x.Id == idArticulo);

            switch (articulo.Tipo)
            {
                case TipoArticulo.normal:
                    ArticuloNormal(articulo, cantidad);
                    break;
                case TipoArticulo.conDescuento:
                    ArticuloDescuento(articulo, cantidad);
                    break;
                case TipoArticulo.TiempoAire:
                    ArticuloTA(articulo, cantidad);
                    break;
            }
        }
        private void ArticuloNormal(Articulos articulo, int cantidad)
        {
            Item articuloNormal = new Item();
            articuloNormal.id = articulo.Id;
            articuloNormal.nombre = articulo.Nombre;
            articuloNormal.precio = articulo.Precio;
            articuloNormal.cantidad = cantidad;
            _ticket.Add(articuloNormal);
        }
        private void ArticuloDescuento(Articulos articulo, int cantidad)
        {
            Console.WriteLine("Este articulo tiene descuento, ingreselo por favor:");
            decimal descu = decimal.Parse(Console.ReadLine());
            ItemDescuento articuloDesc = new ItemDescuento();
            articuloDesc.id = articulo.Id;
            articuloDesc.nombre = articulo.Nombre;
            articuloDesc.precio = articulo.Precio;
            articuloDesc.cantidad = cantidad;
            articuloDesc.descuento = descu;
            _ticket.Add(articuloDesc);
            _totalDescuento += articuloDesc.impDescuento;
        }
        private void ArticuloTA(Articulos articulo, int cantidad)
        {
            Console.WriteLine("Ingrese el numero de telefono:");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese la compañia:");
            string compania = Console.ReadLine();
            Console.WriteLine("Ingrese comision:");
            decimal comision = decimal.Parse(Console.ReadLine());
            ItemTA articuloTA = new ItemTA();
            articuloTA.id = articulo.Id;
            articuloTA.nombre = articulo.Nombre;
            articuloTA.precio = articulo.Precio;
            articuloTA.cantidad = cantidad;
            articuloTA.telefono = telefono;
            articuloTA.compania = compania; 
            articuloTA.comision = comision;
            _ticket.Add(articuloTA);
            _totalComisiones+= articuloTA.comision;
        }

        private void ImprimirTicket()
        {
            Console.WriteLine("\nTICKET\nTICH - TI CAPITAL HUMANO");
            Console.WriteLine("Fecha y hora: " + DateTime.Now);
            foreach (var art in _ticket)
            {
                art.Imprimir();
            }
            Console.WriteLine("Total de articulos: " + _ticket.Count());
            Console.WriteLine("Total a pagar: " + _ticket.Sum(suma => suma.precio));
            _totalVendido += _ticket.Sum(suma => suma.precio);
        }
        public void CorteCaja()
        {
            _totalGeneral = _totalVendido - _totalDescuento + _totalComisiones;
            Console.WriteLine("\nCORTE DE CAJA");
            Console.WriteLine("Total de ventas: " + _totalVentas);
            Console.WriteLine("Importe vendido: " + _totalVendido);
            Console.WriteLine("Total descuentos: " + _totalDescuento);
            Console.WriteLine("Total comisiones: " + _totalComisiones);
            Console.WriteLine("Total en caja: " + _totalGeneral);
            Console.ReadKey();
        }
    }
}