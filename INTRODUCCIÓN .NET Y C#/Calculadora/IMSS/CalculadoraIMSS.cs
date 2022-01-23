using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    internal class CalculadoraIMSS
    {
        public struct Aportaciones
        {
            public decimal EnfermedadMaternidad, InvalidezVida, Retiro, Cesantia, Infonavit;
            public Aportaciones(decimal EM, decimal IV, decimal RE, decimal CE, decimal IN)
            {
                this.EnfermedadMaternidad = EM;
                this.InvalidezVida = IV;    
                this.Retiro = RE;
                this.Cesantia = CE;
                this.Infonavit = IN;
            }
        }
        static void Calcular(decimal sbc, decimal uma)
        {
            Console.WriteLine("Ingrese 1 si es patrón, ingrese 2 si es trabajador:");
            int tipo = Convert.ToInt32(Console.ReadLine());
            Aportaciones aport = new Aportaciones();
            if (tipo == 1) // patron
            {
                aport.EnfermedadMaternidad = (sbc - (uma * 3)) * 0.011m;
                Console.WriteLine("EnfermedadMaternidad: " + aport.EnfermedadMaternidad);
                aport.InvalidezVida = sbc * 0.0175m;
                Console.WriteLine("InvalidezVida: " + aport.InvalidezVida);
                aport.Retiro = sbc * 0.02m;
                Console.WriteLine("Retiro: " + aport.Retiro);
                aport.Cesantia = sbc * 0.0315m;
                Console.WriteLine("Cesantia: " + aport.Cesantia);
                aport.Infonavit = sbc * 0.05m;
                Console.WriteLine("Infonavit: " + aport.Infonavit);
                Console.ReadKey();
            }
            if (tipo == 2) // trabajador
            {
                aport.EnfermedadMaternidad = (sbc - (uma * 3)) * 0.004m;
                Console.WriteLine("EnfermedadMaternidad: " + aport.EnfermedadMaternidad);
                aport.InvalidezVida = sbc * 0.00625m;
                Console.WriteLine("InvalidezVida: " + aport.InvalidezVida);
                aport.Retiro = sbc * 0m;
                Console.WriteLine("Retiro: " + aport.Retiro);
                aport.Cesantia = sbc * 0.01125m;
                Console.WriteLine("Cesantia: " + aport.Cesantia);
                aport.Infonavit = sbc * 0m;
                Console.WriteLine("Infonavit: " + aport.Infonavit);
                Console.ReadKey();
            }
        }
        public void Presentacion()
        {
            Console.WriteLine("Ingrese su Salario Base de Cotización:");
            decimal SBC = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la Unidad de Medida de Actualizacion (mensual):");
            decimal UMA = Convert.ToDecimal(Console.ReadLine());
            Calcular(SBC, UMA);           
        }

    }
}