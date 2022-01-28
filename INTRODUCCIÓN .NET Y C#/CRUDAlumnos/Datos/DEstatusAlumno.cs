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
    public class DEstatusAlumno
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<EstatusAlumno> _listEstatus;
        string query;
        SqlCommand comando;
        public List<EstatusAlumno> Consultar()
        {
            query = "SELECT * FROM EstatusAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                _listEstatus = new List<EstatusAlumno>();
                while (reader.Read())
                {
                    _listEstatus.Add(
                       new EstatusAlumno()
                       {
                           idEstatusAlumno = Convert.ToInt32(reader["idEstatusAlumnos"]),
                           clave = reader["clave"].ToString(),
                           nombre = reader["nombre"].ToString()
                       }
                       );
                }
                con.Close();
            }
            return _listEstatus;
        }
    }
}