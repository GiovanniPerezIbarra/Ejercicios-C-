using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEstatusAlumno
    {
        private DEstatusAlumno _dEstatus;
        public NEstatusAlumno()
        {
            _dEstatus = new DEstatusAlumno();
        }
        public List<EstatusAlumnos> Consultar() => _dEstatus.Consultar();
    }
}
