using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PuntoVenta puntoVenta = new PuntoVenta();
            puntoVenta.IniciarVentas();
            puntoVenta.Ventas();
            puntoVenta.CorteCaja();
        }
    }
}