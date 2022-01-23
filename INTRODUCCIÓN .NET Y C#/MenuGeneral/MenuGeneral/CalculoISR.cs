using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class CalculoISR
    {
        decimal[,] tabla = new decimal[21, 5];
        decimal[,] CargarTabla(string file)
        {
            Console.WriteLine("\n");
            StreamReader sr = new StreamReader(@"C:\Users\Tichs\Desktop\" + file + ".csv");
            string csv = sr.ReadToEnd();
            string[] campos = new string[105];
            campos = csv.Split(',');
            int i = 0;
                for(int j = 0; j < 21; j++)
                {
                    for(int k = 0; k < 5; k++)
                    {
                        tabla[j,k] = decimal.Parse(campos[i++]);
                    }           
                }
            return tabla;
        }
        void Calcular(decimal mensual)
        {
            decimal quincenal = mensual / 2;
            decimal excedente, porcentaje, calculo, total; 
            for (int i = 0; i < 21; i++)
            {
                if (tabla[i,0] <= quincenal && tabla[i,1] >= quincenal)
                {
                    excedente = quincenal - tabla[i,0];
                    porcentaje = excedente * (tabla[i,3] / 100);
                    calculo = tabla[i,2] + porcentaje;
                    total = calculo - tabla[i,4];
                    Console.WriteLine("El ISR a pagar es: " + total);
                    break;
                }
            }
            Console.ReadKey();
        
        }
        public void Presentacion()
        {
            Console.WriteLine("Carga el archivo de tu Tabla ISR:");
            string archivo = Console.ReadLine();
            CargarTabla(archivo);
            Console.WriteLine("Ingrese su sueldo mensual:");
            decimal mensual = decimal.Parse(Console.ReadLine());
            Calcular(mensual);
        }
    }
}