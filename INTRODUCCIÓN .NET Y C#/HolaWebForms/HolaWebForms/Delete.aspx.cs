using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaWebForms
{
    public partial class Delete : System.Web.UI.Page
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            iddetail.Text = id;
            string nombre = Request.QueryString["nombre"];
            nombredetail.Text = nombre;
            string clave = Request.QueryString["clave"];
            clavedetail.Text = clave;
        }
        protected void eliminarBtn_Click(object sender, EventArgs e)
        {
            Response.Write("<script>let isTrue = confirm('¿Estás seguro?')</script>");
            int i;
            string query = $"DELETE EstatusAlumnos WHERE idEstatusAlumnos = " +
                    $"{int.Parse(iddetail.Text)}";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                i = comando.ExecuteNonQuery();
                con.Close();
            }
            Response.Write("<script>alert('Eliminado exitosamente.');" +
                           "window.location.href='Inicio'</script>");
        }
    }
}