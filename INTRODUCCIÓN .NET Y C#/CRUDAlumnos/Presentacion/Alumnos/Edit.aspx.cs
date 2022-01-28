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
    public partial class Edit : System.Web.UI.Page
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        SqlCommand comando;
        List<Alumno> lstalumnos;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarEstados();
                llenarEstatus();
                string id = Request.QueryString["id"];
                id = id == null ? "14" : id;
                NAlumno nalumno = new NAlumno();
                Alumno alumno = nalumno.Consultar(int.Parse(id));
                idbox.Text = alumno.idAlumnos.ToString();
                nombrebox.Text = alumno.nombre;
                pabox.Text = alumno.primerApellido;
                sabox.Text = alumno.segundoApellido;
                fnbox.Text = alumno.fechaNacimiento.ToString("yyyy-MM-dd");
                curpbox.Text = alumno.curp;
                mailbox.Text = alumno.correo;
                phonebox.Text = alumno.telefono;
                estadolist.Text = alumno.idEstadoOrigen.ToString();
                estatuslist.Text = alumno.idEstatus.ToString();
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
                    idAlumnos = Convert.ToInt32(idbox.Text),
                    nombre = nombrebox.Text,
                    primerApellido = pabox.Text,
                    segundoApellido = sabox.Text,
                    correo = mailbox.Text,
                    telefono = phonebox.Text,
                    fechaNacimiento = Convert.ToDateTime(fnbox.Text),
                    curp = curpbox.Text,
                    sueldo = 0,
                    idEstadoOrigen = Convert.ToInt32(estadolist.SelectedValue),
                    idEstatus = Convert.ToInt16(estatuslist.SelectedValue),
                });
            }
            NAlumno nalumno = new NAlumno();
            Alumno obj = lstalumnos.Find(x => x.idAlumnos == Convert.ToInt32(idbox.Text));
            nalumno.Actualizar(obj);
        }
    }
}