using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Presentacion.Alumnos
{
    public partial class Create : System.Web.UI.Page
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        SqlCommand comando;
        List<Alumno> lstalumnos;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarEstatus();
                llenarEstados();
            }
        }
        void llenarEstatus()
        {
            using (SqlConnection con = new SqlConnection(conection))
            {
                con.Open();
                DataSet dt = new DataSet();
                comando = new SqlCommand("consultarTEstatus", con);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comando;
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                estatuslist.DataSource = tabla;
                estatuslist.DataValueField = "idEstatusAlumnos";
                estatuslist.DataTextField = "nombre";
                estatuslist.DataBind();
                con.Close();
            }
        }
        void llenarEstados()
        {
            using (SqlConnection con = new SqlConnection(conection))
            {
                con.Open();
                DataSet dt = new DataSet();
                comando = new SqlCommand("consultarTEstado", con);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comando;
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                estadolist.DataSource = tabla;
                estadolist.DataValueField = "idEstados";
                estadolist.DataTextField = "nombre";
                estadolist.DataBind();
                con.Close();
            }
        }
        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            lstalumnos = new List<Alumno>();
            {
                lstalumnos.Add(new Alumno
                {
                    nombre = nombrebox.Text,
                    primerApellido = pabox.Text,
                    segundoApellido = sabox.Text,
                    correo = mailbox.Text,
                    telefono = phonebox.Text,
                    fechaNacimiento = Convert.ToDateTime(fnbox.Text),
                    curp = curpbox.Text,
                    sueldo = Convert.ToDecimal(sueldobox.Text),
                    idEstadoOrigen = Convert.ToInt32(estadolist.SelectedValue),
                    idEstatus = Convert.ToInt16(estatuslist.SelectedValue),
                });
            }
            NAlumno nalumno = new NAlumno();
            Alumno obj = lstalumnos.Find(x => x.idAlumnos == 0);
            nalumno.Agregar(obj);
            Response.Write("<script>alert('Agregado exitosamente.');" +
                           "window.location.href='Index'</script>");
        }
    }
}