using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFAlumno
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAlumnoWCF" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAlumnoWCF
    {
        [OperationContract]
        AportacionesIMSS CalcularIMSS(int id);
        [OperationContract]
        TablaISR CalcularISR(int id);
    }
}