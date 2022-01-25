using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstatusAlumnosADO
{
    internal class ADOEstatus : ICRUD
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Estatus> _listEstatus;
        string query;
        SqlCommand comando;
        public List<Estatus> Consultar()
        {
            query = "SELECT * FROM EstatusAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                _listEstatus = new List<Estatus>();
                while (reader.Read())
                {
                    _listEstatus.Add(
                       new Estatus()
                       {
                           id = Convert.ToInt32(reader["idEstatusAlumnos"]),
                           clave = reader["clave"].ToString(),
                           nombre = reader["nombre"].ToString()
                       }
                       );
                }
                con.Close();
            }
            return _listEstatus;
        }
        public Estatus Consultar(int id)
        {
            Estatus estatusuno = new Estatus();
            query = $"SELECT * FROM EstatusAlumnos WHERE idEstatusAlumnos = {id}";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    estatusuno = new Estatus { id = Convert.ToInt32(reader["idEstatusAlumnos"]),
                        clave = reader["clave"].ToString(), nombre = reader["nombre"].ToString() };
                }
                con.Close();
            }
            return estatusuno;
        }
        public int Agregar(Estatus estatus)
        {
            int idES;
            query = $"INSERT INTO EstatusAlumnos (clave, nombre) VALUES (@clave, @nombre)";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@clave", estatus.clave);
                comando.Parameters.AddWithValue("@nombre", estatus.nombre);
                con.Open();
                idES = Convert.ToInt32(comando.ExecuteScalar());
                con.Close();
            }
            return idES;
        }
            public void Actualizar(Estatus estatus)
        {
            query = $"UPDATE EstatusAlumnos SET clave = '{estatus.clave}', nombre = '{estatus.nombre}'" +
                    $"WHERE idEstatusAlumnos = {estatus.id}";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void Eliminar(int id)
        {
            query = $"DELETE EstatusAlumnos WHERE idEstatusAlumnos = {id}";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}