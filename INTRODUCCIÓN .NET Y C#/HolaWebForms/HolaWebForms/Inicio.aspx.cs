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
    public partial class Inicio : System.Web.UI.Page
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {   
            if(!IsPostBack)
                llenadropdownlist();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void llenadropdownlist()
        {
            using (SqlConnection con = new SqlConnection(conection))
            {
                con.Open();
                DataSet dt = new DataSet();
                string query = "SELECT * FROM EstatusAlumnos";
                comando = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comando;
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                DropDownList1.DataSource = tabla;
                DropDownList1.DataValueField = "idEstatusAlumnos";
                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataBind();
                con.Close();
            }
        }
        protected void crear_Click(object sender, EventArgs e)
        {

        }
        protected void ver_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DropDownList1.SelectedValue);
            using (SqlConnection con = new SqlConnection(conection))
            {
                con.Open();
                DataSet dt = new DataSet();
                string query = $"SELECT * FROM EstatusAlumnos WHERE idEstatusAlumnos = {id}";
                comando = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comando;
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                string nombre = tabla.Rows[0]["nombre"].ToString();
                string clave = tabla.Rows[0]["clave"].ToString();
                string url = $"Details.aspx?id={id}&nombre={nombre}&clave={clave}";
                Response.Redirect(url, true);
                con.Close();
            }
        }
        protected void cambiar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DropDownList1.SelectedValue);
            using (SqlConnection con = new SqlConnection(conection))
            {
                con.Open();
                DataSet dt = new DataSet();
                string query = $"SELECT * FROM EstatusAlumnos WHERE idEstatusAlumnos = {id}";
                comando = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comando;
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                string nombre = tabla.Rows[0]["nombre"].ToString();
                string clave = tabla.Rows[0]["clave"].ToString();
                string url = $"Edit.aspx?id={id}&nombre={nombre}&clave={clave}";
                Response.Redirect(url, true);
                con.Close();
            }
        }
        protected void borrar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DropDownList1.SelectedValue);
            using (SqlConnection con = new SqlConnection(conection))
            {
                con.Open();
                DataSet dt = new DataSet();
                string query = $"SELECT * FROM EstatusAlumnos WHERE idEstatusAlumnos = {id}";
                comando = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comando;
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                string nombre = tabla.Rows[0]["nombre"].ToString();
                string clave = tabla.Rows[0]["clave"].ToString();
                string url = $"Delete.aspx?id={id}&nombre={nombre}&clave={clave}";
                Response.Redirect(url, true);
                con.Close();
            }
        }
    }
}