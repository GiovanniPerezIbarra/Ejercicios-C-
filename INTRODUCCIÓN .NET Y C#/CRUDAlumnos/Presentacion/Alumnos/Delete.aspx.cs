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
    public partial class Delete : System.Web.UI.Page
    {
        NAlumno nalumno = new NAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {          
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                id = id == null ? "14" : id;
                Alumno alumno = nalumno.Consultar(int.Parse(id));
                idlbl.Text = alumno.idAlumnos.ToString();
                nombrelbl.Text = alumno.nombre;
                palbl.Text = alumno.primerApellido;
                salbl.Text = alumno.segundoApellido;
                fnlbl.Text = alumno.fechaNacimiento.ToString();
                curplbl.Text = alumno.curp;
                emaillbl.Text = alumno.correo;
                phonelbl.Text = alumno.telefono;
                estadolbl.Text = alumno.idEstadoOrigen.ToString();
                estatuslbl.Text = alumno.idEstatus.ToString();
            }
        }

        protected void eliminarBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idlbl.Text);
            nalumno.Eliminar(id);
        }

    }
}