using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class DAlumno
    {
        private InstitutoTichEntities dbcontext = new InstitutoTichEntities();
        public List<Alumnos> Consultar()
        {
            List<Alumnos> alumnos = dbcontext.Alumnos.ToList();
            return alumnos;
        }
        public Alumnos Consultar(int id)
        {
            Alumnos alumnoencontrado = dbcontext.Alumnos.Find(id);
            return alumnoencontrado;
        }
        public void Agregar(Alumnos alumno)
        {
            dbcontext.Alumnos.Add(alumno);
            dbcontext.SaveChanges();
        }
        public void Actualizar(Alumnos alumno)
        {
            dbcontext.Entry(alumno).State = EntityState.Modified;
            dbcontext.SaveChanges();
        }
        public void Eliminar(int id)
        {
            Alumnos alumnos = dbcontext.Alumnos.Find(id);
            dbcontext.Alumnos.Remove(alumnos);
            dbcontext.SaveChanges();
        }
    }
}