﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class Item : ItemBase
    {
        public override void Imprimir()
        {
            Console.Write($"{id} {nombre} {precio} {cantidad} {subtotal()}");
            Console.WriteLine($"Total: {total()}");
        }
    }
}
