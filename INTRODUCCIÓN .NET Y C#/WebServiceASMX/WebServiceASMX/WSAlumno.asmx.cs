using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Datos;
using Entidades;
using Negocio;

namespace WebServiceASMX
{
    /// <summary>
    /// Descripción breve de WSAlumno
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WSAlumno : System.Web.Services.WebService
    {

        [WebMethod]
        public TablaISR CalcularISR(int id)
        {
            NAlumno nAlumno = new NAlumno();
            TablaISR tablaISR = nAlumno.CalcularISR(id);
            return tablaISR;
        }
    }
}