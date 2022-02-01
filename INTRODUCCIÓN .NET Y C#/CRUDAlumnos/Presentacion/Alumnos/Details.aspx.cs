using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

namespace Presentacion.Alumnos
{
    public partial class Details : System.Web.UI.Page
    {
        NAlumno nuevo = new NAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                NAlumno nalumno = new NAlumno();
                Alumno alumno = nalumno.Consultar(int.Parse(id));
                idlbl.Text = alumno.idAlumnos.ToString();
                nombrelbl.Text = alumno.nombre;
                palbl.Text = alumno.primerApellido;
                salbl.Text = alumno.segundoApellido;
                fnlbl.Text = alumno.fechaNacimiento.ToString("dd/MM/yyyy");
                curplbl.Text = alumno.curp;
                emaillbl.Text = alumno.correo;
                phonelbl.Text = alumno.telefono;
                estadolbl.Text = alumno.idEstadoOrigen.ToString();
                estatuslbl.Text = alumno.idEstatus.ToString();
            }
        }
        protected void imssBtn_Click(object sender, EventArgs e)
        {
            AportacionesIMSS aportaciones = nuevo.CalcularIMSS(Convert.ToInt32(idlbl.Text));
            m1.Text = aportaciones.enfermedadMaternidad.ToString();
            m2.Text = aportaciones.invalidezVida.ToString();
            m3.Text = aportaciones.retiro.ToString();
            m4.Text = aportaciones.cesantía.ToString();
            m5.Text = aportaciones.infonavit.ToString();
            Modal.Show();
        }
    }
}