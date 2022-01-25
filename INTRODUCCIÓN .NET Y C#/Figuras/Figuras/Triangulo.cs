using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Triangulo : IFigura
    {
        public decimal bases { get; set; }
        public decimal altura { get; set; }
        public decimal CalcularArea()
        {
            return (bases * altura) / 2;
        }
        public decimal CalcularPerimetro()
        {
            return bases * 3;
        }
    }
}