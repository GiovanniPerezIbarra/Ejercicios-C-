using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class ItemTA : ItemBase
    {
        public string telefono { get; set; }
        public string compania { get; set; }
        public decimal comision { get; set; }
        public override decimal total()
        {
            return base.subtotal() + this.comision;
        }
        public override void Imprimir()
        {
            Console.Write($"{id} {nombre} {precio} {cantidad} {subtotal()}");
            Console.WriteLine($"Telefono: {telefono}, Compañía: {compania}, Total: {total()}");
        }
    }
}
