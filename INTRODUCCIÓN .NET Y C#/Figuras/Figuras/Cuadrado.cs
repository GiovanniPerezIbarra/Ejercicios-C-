using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Cuadrado : IFigura
    {
        public decimal lado { get; set; }
        public decimal CalcularArea()
        {
            return lado * lado;
        }
        public decimal CalcularPerimetro()
        {
            return lado * 4;
        }
    }
}