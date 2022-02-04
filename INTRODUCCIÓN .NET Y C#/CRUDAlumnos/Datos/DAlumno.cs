using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DAlumno
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Alumno> _listAlumno;
        List<TablaISR> _listISR;
        SqlCommand comando;
        public List<Alumno> Consultar()
        {
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand("consultarTodos", con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                _listAlumno = new List<Alumno>();
                while (reader.Read())
                {
                    _listAlumno.Add(new Alumno
                    {
                        idAlumnos = reader.GetInt32(0),
                        nombre = reader.GetString(1),
                        primerApellido = reader.GetString(2),
                        segundoApellido = reader.GetString(3),
                        correo = reader.GetString(4),
                        telefono = reader.GetString(5),
                        fechaNacimiento = reader.GetDateTime(6),
                        curp = reader.GetString(7),
                        sueldo = reader.GetDecimal(8),
                        idEstadoOrigen = reader.GetInt32(9),
                        idEstatus = reader.GetInt16(10),
                    });
                }
                con.Close();
            }
            return _listAlumno;
        }
        public Alumno Consultar(int id)
        {
            Alumno alumno = new Alumno();
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand("consultarEAlumnos", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumnos", id);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    alumno.idAlumnos = reader.GetInt32(0);
                    alumno.nombre = reader.GetString(1);
                    alumno.primerApellido = reader.GetString(2);
                    alumno.segundoApellido = reader.GetString(3);
                    alumno.correo = reader.GetString(4);
                    alumno.telefono = reader.GetString(5);
                    alumno.fechaNacimiento = reader.GetDateTime(6);
                    alumno.curp = reader.GetString(7);
                    alumno.sueldo = reader.GetDecimal(8);
                    alumno.idEstadoOrigen = reader.GetInt32(9);
                    alumno.idEstatus = reader.GetInt16(10);
                }
                con.Close();
            }
            return alumno;
        }
        public void Agregar(Alumno alumno)
        {
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand("agregarAlumnos", con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                comando.Parameters.AddWithValue("@nombre", alumno.nombre);
                comando.Parameters.AddWithValue("@primerApellido", alumno.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", alumno.segundoApellido);
                comando.Parameters.AddWithValue("@correo", alumno.correo);
                comando.Parameters.AddWithValue("@telefono", alumno.telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", alumno.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", alumno.curp);
                comando.Parameters.AddWithValue("@sueldo", alumno.sueldo);
                comando.Parameters.AddWithValue("@idEstadoOrigen", alumno.idEstadoOrigen);
                comando.Parameters.AddWithValue("@idEstatus", alumno.idEstatus);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void Actualizar(Alumno alumno)
        {
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand("actualizarAlumnos", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", alumno.idAlumnos);
                con.Open();
                comando.Parameters.AddWithValue("@nombre", alumno.nombre);
                comando.Parameters.AddWithValue("@primerApellido", alumno.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", alumno.segundoApellido);
                comando.Parameters.AddWithValue("@correo", alumno.correo);
                comando.Parameters.AddWithValue("@telefono", alumno.telefono);
                comando.Parameters.AddWithValue("@fechaNacimiento", alumno.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", alumno.curp);
                comando.Parameters.AddWithValue("@sueldo", alumno.sueldo);
                comando.Parameters.AddWithValue("@idEstadoOrigen", alumno.idEstadoOrigen);
                comando.Parameters.AddWithValue("@idEstatus", alumno.idEstatus);
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public void Eliminar(int id)
        {
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand("eliminarAlumnos", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", id);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
        public List<TablaISR> ConsultarTablaISR()
        {
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand("consultarTodosISR", con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                _listISR = new List<TablaISR>();
                while (reader.Read())
                {
                    _listISR.Add(new TablaISR
                    {
                        límiteInferior = reader.GetDecimal(1),
                        límiteSuperior = reader.GetDecimal(2),
                        cuotaFija = reader.GetDecimal(3),
                        excedente = reader.GetDecimal(4),
                        subsidio = reader.GetDecimal(5),
                    });
                }        
                con.Close();
                return _listISR;
            }
        }
    }
}