using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public class Poliza
    {
        static void Calcular(DateTime inicioVigencia, int tipoPeriodo, int cantidadPeriodos, decimal sumaAsegurada,
                             DateTime fechaNacimiento, decimal genero)
        {
            decimal[,] factorC =
            {
                {0, 20, 1, 0.05m},
                {21, 30, 1, 0.1m},
                {31, 40, 1, 0.4m},
                {41, 50, 1, 0.5m},
                {51, 60, 1, 0.65m},
                {61, 200, 1, 0.85m},
                {0, 20, 2, 0.05m},
                {21, 30, 2, 0.1m},
                {31, 40, 2, 0.4m},
                {41, 50, 2, 0.55m},
                {51, 60, 2, 0.7m},
                {61, 200, 2, 0.9m}
            };
            decimal edad = CalcularEdad(fechaNacimiento);
            decimal factor = 0;
            for (int i = 0; i <= 11; i++)
            {
                if (factorC[i, 2] == genero && edad >= factorC[i, 0] && edad <= factorC[i, 1])
                {
                    factor = factorC[i, 3];
                    break;
                }
            }            
            PolizaResultado pol = new PolizaResultado();
            string finVigencia;
            if (tipoPeriodo == 1)
            {
                pol.Prima = (sumaAsegurada * factor) * ((cantidadPeriodos * 365) / 360);
                Console.WriteLine("La prima a pagar es de: " + pol.Prima);
                finVigencia = inicioVigencia.AddDays(cantidadPeriodos * 365).ToString("dd/MM/yyyy");
                Console.WriteLine("La poliza vencerá el: " + finVigencia);
            }
            if(tipoPeriodo == 2)
            {
                pol.Prima = (sumaAsegurada * factor) * ((cantidadPeriodos * 30) / 360);
                Console.WriteLine("La prima a pagar es de: " + pol.Prima);
                finVigencia = inicioVigencia.AddDays(cantidadPeriodos * 30).ToString("dd/MM/yyyy"); ;
                Console.WriteLine("La poliza vencerá el: " + finVigencia);
            }
            if(tipoPeriodo == 3)
            {
                pol.Prima = (sumaAsegurada * factor) * (cantidadPeriodos / 360);
                Console.WriteLine("La prima a pagar es de: " + pol.Prima);
                finVigencia = inicioVigencia.AddDays(cantidadPeriodos).ToString("dd/MM/yyyy"); ;
                Console.WriteLine("La poliza vencerá el: " + finVigencia);
            }
        }
        public static decimal CalcularEdad(DateTime fechaNac)
        {
            DateTime fechaActual = DateTime.Today;
            if (fechaNac > fechaActual)
            {
                return -1;
            }
            else
            {
                decimal edad = fechaActual.Year - fechaNac.Year;
                if (fechaNac.Month > fechaActual.Month)
                {
                    --edad;
                }
                return edad;
            }
        }
        public void Presentacion()
        {
            Console.WriteLine("Ingrese la fecha de inicio de vigencia (año-mes-dia):");
            DateTime inicioVigencia = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 si el periodo es por año, 2 si es por mes, 3 si es por dia:");
            int tipoPeriodo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de periodos que se desean como duración de la póliza:");
            int cantidadPeriodos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la suma asegurada:");
            decimal sumaAsegurada = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese su fecha de nacimiento (año-mes-dia):");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 si es género femenino, 2 si es género masculino:");
            decimal genero = Convert.ToDecimal(Console.ReadLine());
            Calcular(inicioVigencia, tipoPeriodo, cantidadPeriodos, sumaAsegurada, fechaNacimiento, genero);
            Console.ReadKey();
            Console.Clear();
        }
    }
}