using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class ItemDescuento : ItemBase
    {
        public decimal descuento { get; set; }
        public decimal impDescuento { get
            {
                return (precio * cantidad) * descuento / 100; 
            }
        }
        public override decimal total()
        {
            return base.subtotal() - this.impDescuento;
        }
        public override void Imprimir()
        {
            Console.Write($"{id} {nombre} {precio} {cantidad} {subtotal()}");
            Console.WriteLine($"Descuento {descuento}%, impDescuento: {impDescuento}, Total: {total()}");
        }
    }
}