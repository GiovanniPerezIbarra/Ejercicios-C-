using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    internal class Cadenas
    {
        public void HolaMundo()
        {  
            string nombre, primerApellido, segundoApellido, edad, juntar;
            Console.WriteLine("Proporciona tu nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Proporciona tu primer apellido:");
            primerApellido = Console.ReadLine();
            Console.WriteLine("Proporciona tu segundo apellido:");
            segundoApellido = Console.ReadLine();
            Console.WriteLine("Proporciona tu edad:");
            edad = Console.ReadLine();
            Console.WriteLine("Hola "+nombre.Trim()+" "+primerApellido.Trim()+" "+segundoApellido.Trim());
            Console.WriteLine("{0} {1} {2} tiene {3} años", nombre.Trim(), primerApellido.Trim(), segundoApellido.Trim(), edad.Trim());
            Console.WriteLine($"Gusto en conocerte {nombre.ToUpper()} {primerApellido.ToUpper()} {segundoApellido.ToUpper()}!!!");
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream($"C:\\Users\\Tichs\\Documents\\Diplomado.Net\\{nombre}{primerApellido}{segundoApellido}.docx", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                return;
            }
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.ReadKey();         
        }
    }
}