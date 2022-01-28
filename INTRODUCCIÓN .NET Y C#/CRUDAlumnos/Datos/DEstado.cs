using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DEstado
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Estado> _listEstado;
        string query;
        SqlCommand comando;
        public List<Estado> Consultar()
        {
            query = "SELECT * FROM EstatusAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                _listEstado = new List<Estado>();
                while (reader.Read())
                {
                    _listEstado.Add(
                       new Estado()
                       {
                           idEstados = Convert.ToInt32(reader["idEstatusAlumnos"]),
                           nombre = reader["clave"].ToString(),
                       }
                       );
                }
                con.Close();
            }
            return _listEstado;
        }
    }
}
