using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigura[] figuritas = { new Cuadrado { lado = 5 }, new Triangulo { bases = 5, altura = 5 } };
            foreach (var calculo in figuritas)
            {
                Console.WriteLine($"Figura {calculo.ToString()}," +
                    $"area: {calculo.CalcularArea()}," +
                    $"perimetro: {calculo.CalcularPerimetro()}");
            }
        }
    }
}
