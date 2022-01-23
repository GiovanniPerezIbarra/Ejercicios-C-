using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    internal class Calculadora
    {
        public static decimal Suma(decimal num1, decimal num2)
        {
            decimal Resultado = num1 + num2;
            Console.WriteLine("El resultado es: " + Resultado);
            return Resultado;
        }
        public static decimal Resta(decimal num1, decimal num2)
        {
            decimal Resultado = num1 - num2;
            Console.WriteLine("El resultado es: " + Resultado);
            return Resultado;
        }
        public static decimal Multiplicacion(decimal num1, decimal num2)
        {
            decimal Resultado = num1 * num2;
            Console.WriteLine("El resultado es: " + Resultado);
            return Resultado;
        }
        public static decimal Division(decimal num1, decimal num2)
        {
            decimal Resultado = num1 / num2;
            Console.WriteLine("El resultado es: " + Resultado);
            return Resultado;
        }
        public static decimal Modulo(decimal num1, decimal num2)
        {
            decimal Resultado = num1 % num2;
            Console.WriteLine("El resultado es: " + Resultado);
            return Resultado;
        }
        public enum tipoOperacion : int
        {
            suma = 1,
            resta = 2,
            multiplicacion = 3,
            division = 4,
            residuo = 5
        }
        struct operacion
        {
            public decimal operando1, operando2;
            public tipoOperacion operador;
            public operacion(decimal oper1, decimal oper2, tipoOperacion oper)
            {
                this.operando1 = oper1;
                this.operando2 = oper2;
                this.operador = oper;
            }
        }
        public void Operacion(tipoOperacion opera, decimal operando1, decimal operando2)
        {
            switch (opera)
            {
                case tipoOperacion.suma:
                    Suma(operando1, operando2);
                    break;
                case tipoOperacion.resta:
                    Resta(operando1, operando2);
                    break;
                case tipoOperacion.multiplicacion:
                    Multiplicacion(operando1, operando2);
                    break;
                case tipoOperacion.division:
                    Division(operando1, operando2);
                    break;
                case tipoOperacion.residuo:
                    Modulo(operando1, operando2);
                    break;
                default:
                    Console.WriteLine("No existe");
                    break; 
            }
        }
        struct Resultados
        {
            public int suma, resta, multiplicar, division, modulo;
            public Resultados(int sum, int res, int multi, int div, int mod)
            {
                this.suma = sum;
                this.resta = res;
                this.multiplicar = multi;
                this.division = div;
                this.modulo = mod;
            }
        }
        static void Simultaneas(decimal num1, decimal num2)
        {
            Resultados resul = new Resultados();
            resul.suma = 1;
            resul.resta = 2;
            resul.multiplicar = 3;
            resul.division = 4;
            resul.modulo = 5;
            Calculadora calcu = new Calculadora();
            int[] TodasOperaciones = new int[] {resul.suma, resul.resta, resul.multiplicar, resul.division, resul.modulo};
            for (int i = 0; i<5; i++)
            {
                calcu.Operacion((tipoOperacion)TodasOperaciones[i], num1, num2);
            }
        }
        public void Presentacion()
        {
            Console.WriteLine("\nOperación a realizar\n1.- Suma\n2.- Resta\n3.- Multiplicación\n4.- Dividir\n" +
                "5.- Módulo\n6 - Todas\n\nSeleccione la operación a realizar:");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Proporciona el primer operador:");
            int operador1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Proporciona el segundo operador:");
            int operador2 = Convert.ToInt32(Console.ReadLine());
            if(opcion == 6)
            {
                Simultaneas(operador1, operador2);
                Console.ReadLine();
            }
            else{
                Operacion((tipoOperacion)opcion, operador1, operador2);
                Console.ReadLine();
            }
        } 
    }
}
