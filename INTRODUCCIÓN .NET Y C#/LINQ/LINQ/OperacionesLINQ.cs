using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LINQ
{
    internal class OperacionesLINQ
    {
        public void Consultas()
        {
            string pathalumnos = @"C:\Users\Tichs\Desktop\Alumnos.json";
            StreamReader jsonAlumno = new StreamReader(pathalumnos);
            string jsonA = jsonAlumno.ReadToEnd();
            jsonAlumno.Close();
            List<Alumnos> alumnos = JsonConvert.DeserializeObject<List<Alumnos>>(jsonA);

            string pathestados = @"C:\Users\Tichs\Desktop\Estados.json";
            StreamReader jsonEstados = new StreamReader(pathestados);
            string jsonE = jsonEstados.ReadToEnd();
            jsonEstados.Close();
            List<Estado> estados = JsonConvert.DeserializeObject<List<Estado>>(jsonE);

            string pathestatus = @"C:\Users\Tichs\Desktop\Estatus.json";
            StreamReader jsonEstatus = new StreamReader(pathestatus);
            string jsonEA = jsonEstatus.ReadToEnd();
            jsonEstatus.Close();
            List<Estatus> estatus = JsonConvert.DeserializeObject<List<Estatus>>(jsonEA);

            string pathisr = @"C:\Users\Tichs\Desktop\TablaISR.csv";
            List<ItemISR> ISR = 
        }
    }
}
