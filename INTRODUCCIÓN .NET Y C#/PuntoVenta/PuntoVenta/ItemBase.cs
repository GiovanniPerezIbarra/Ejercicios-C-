using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public abstract class ItemBase
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public virtual decimal subtotal() => precio * cantidad;
        public virtual decimal total() => precio * cantidad;
        public abstract void Imprimir();
    }
}