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
    public partial class Create : System.Web.UI.Page
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void guardarBtn_Click(object sender, EventArgs e)
        {
            int i;
            string query = $"INSERT INTO EstatusAlumnos (clave, nombre) VALUES (@clave, @nombre)";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@nombre", nombretext.Text);
                comando.Parameters.AddWithValue("@clave", clavetext.Text);
                con.Open();
                i = comando.ExecuteNonQuery();
                con.Close();
            }
            Response.Write("<script>alert('Guardado exitosamente.');</script>");
        }
        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            nombretext.Text = "";
            clavetext.Text = "";
        }
    }
}