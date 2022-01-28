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
    public partial class Edit : System.Web.UI.Page
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string nombre = Request.QueryString["nombre"];
                nombreedit.Text = nombre;
                string clave = Request.QueryString["clave"];
                claveedit.Text = clave;
            }
        }
        protected void actualizarBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            int i;
            string query = $"UPDATE EstatusAlumnos SET nombre = '{nombreedit.Text}', " +
                $"clave = '{claveedit.Text}' WHERE idEstatusAlumnos = " +
                $"{id}";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                i = comando.ExecuteNonQuery();
                con.Close();
            }
            Response.Write("<script>alert('Actualizado exitosamente.');</script>");
        }
    }
}