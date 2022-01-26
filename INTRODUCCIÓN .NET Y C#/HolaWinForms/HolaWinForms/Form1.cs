using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaWinForms
{
    public partial class Form1 : Form
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        SqlCommand comando;
        public Form1()
        {
            InitializeComponent();
        }
        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            ModificarBtn.Enabled = false;   
            PanelAgregar.Visible = true;      
        }
        private void ventana_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            PanelAgregar.Visible = false;
            AgregarBtn.Enabled = true;
            ModificarBtn.Enabled = true;
            NombreText.Text = "";
            ClaveText.Text = "";
        }
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if(ModificarBtn.Enabled == false)
            {
                int i;
                string query = $"INSERT INTO EstatusAlumnos (clave, nombre) VALUES (@clave, @nombre)";
                using (SqlConnection con = new SqlConnection(conection))
                {
                    comando = new SqlCommand(query, con);
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@nombre", NombreText.Text);
                    comando.Parameters.AddWithValue("@clave", ClaveText.Text);
                    con.Open();
                    i = comando.ExecuteNonQuery();
                    con.Close();
                }
                if (i != 0)
                {
                    MessageBox.Show("Guardado con exito.");
                }
                NombreText.Text = "";
                ClaveText.Text = "";
                PanelAgregar.Visible = false;
            }
            if(AgregarBtn.Enabled == false)
            {
                int i;
                string query = $"UPDATE EstatusAlumnos SET nombre = '{NombreText.Text}'," +
                    $"clave = '{ClaveText.Text}' WHERE idEstatusAlumnos = " +
                    $"{Convert.ToInt32(EstatusBox.SelectedValue)}";
                using (SqlConnection con = new SqlConnection(conection))
                {
                    comando = new SqlCommand(query, con);
                    comando.CommandType = CommandType.Text;
                    con.Open();
                    i = comando.ExecuteNonQuery();
                    con.Close();
                }
                if (i != 0)
                {
                    MessageBox.Show("Actualizado con exito.");
                }
                NombreText.Text = "";
                ClaveText.Text = "";
                PanelAgregar.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            llenagridview();
            llenacombobox();
        }
        private void EstatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void llenagridview()
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
                con.Close();
                ventana.DataSource = tabla;
            }
        }
        private void llenacombobox()
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
                con.Close();
                EstatusBox.DataSource = tabla;
                EstatusBox.ValueMember = "idEstatusAlumnos";
                EstatusBox.DisplayMember = "nombre";
            }
        }
        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            AgregarBtn.Enabled = false;
            PanelAgregar.Visible = true;
            NombreText.Text = EstatusBox.Text;
            using (SqlConnection con = new SqlConnection(conection))
            {
                con.Open();
                DataSet dt = new DataSet();
                string query = $"SELECT clave FROM EstatusAlumnos WHERE nombre = '{EstatusBox.Text}'";
                comando = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comando;
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                ClaveText.Text = tabla.Rows[0]["clave"].ToString();
                con.Close();
            }
           
        }
        private void EliminarBtn_Click(object sender, EventArgs e)
        {
                DialogResult dialogResult = MessageBox.Show("¿Deseas eliminar el registro?",
                                            "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int i;
                string query = $"DELETE EstatusAlumnos WHERE idEstatusAlumnos =" +
                        $"{Convert.ToInt32(EstatusBox.SelectedValue)}";
                using (SqlConnection con = new SqlConnection(conection))
                {
                    comando = new SqlCommand(query, con);
                    comando.CommandType = CommandType.Text;
                    con.Open();
                    i = comando.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro eliminado.");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
    }
}