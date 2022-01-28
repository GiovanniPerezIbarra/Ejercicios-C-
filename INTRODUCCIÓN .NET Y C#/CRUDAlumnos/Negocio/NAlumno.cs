using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class NAlumno
    {
        private DAlumno _dAlumno;
        public NAlumno()
        {
            _dAlumno = new DAlumno();
        }
        public void Actualizar(Alumno alumno) => _dAlumno.Actualizar(alumno);

        public void Agregar(Alumno alumno) => _dAlumno.Agregar(alumno);

        public List<Alumno> Consultar()
        {
            throw new NotImplementedException();
        }

        public Alumno Consultar(int id) => _dAlumno.Consultar(id);

        public void Eliminar(int id) => _dAlumno.Eliminar(id);
    }
}