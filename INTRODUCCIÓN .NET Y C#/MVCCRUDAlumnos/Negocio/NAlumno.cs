using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using Negocio.ServiceReference1;

namespace Negocio
{
    public class NAlumno
    {
        private AlumnoWCFClient serv = new AlumnoWCFClient();
        private DAlumno _dAlumno;
        private AlumnoWCFClient hola;
        public NAlumno()
        {
            _dAlumno = new DAlumno();
            hola = new AlumnoWCFClient();
        }
        public void Actualizar(Alumnos alumno) => _dAlumno.Actualizar(alumno);

        public void Agregar(Alumnos alumno) => _dAlumno.Agregar(alumno);

        public List<Alumnos> Consultar() => _dAlumno.Consultar();

        public Alumnos Consultar(int id) => _dAlumno.Consultar(id);

        public void Eliminar(int id) => _dAlumno.Eliminar(id);
        public AportacionesIMSS CalcularIMMS(int id)
        {
            return serv.CalcularIMSS(id);
        }
        public TablaISR CalcularISR(int id)
        {
            return serv.CalcularISR(id);
        }
    }
}