using Negocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace WCFAlumno
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AlumnoWCF" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AlumnoWCF.svc o AlumnoWCF.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AlumnoWCF : IAlumnoWCF
    {
        public AportacionesIMSS CalcularIMSS(int id)
        {
            NAlumno alumno = new NAlumno();
            Entidades.AportacionesIMSS imssentidades = alumno.CalcularIMSS(id);
            AportacionesIMSS imsswcf = new AportacionesIMSS();
            imsswcf.enfermedadMaternidad = imssentidades.enfermedadMaternidad;
            imsswcf.invalidezVida = imssentidades.invalidezVida;
            imsswcf.retiro = imssentidades.retiro;
            imsswcf.cesantía = imssentidades.cesantía;
            imsswcf.infonavit = imssentidades.infonavit;
            return imsswcf;
        }

        public TablaISR CalcularISR(int id)
        {
            NAlumno alumno = new NAlumno();
            Entidades.TablaISR tablaISR = alumno.CalcularISR(id);
            var jsonISR = JsonConvert.SerializeObject(tablaISR);
            File.WriteAllText(@"C:\Users\Tichs\Documents\DESARROLLADOR .NET\INTRODUCCIÓN .NET Y C#\WCFAlumno\ISR.json", jsonISR);
            var desjsonISR = JsonConvert.DeserializeObject<TablaISR>(jsonISR);
            return desjsonISR;
        }
    }
}