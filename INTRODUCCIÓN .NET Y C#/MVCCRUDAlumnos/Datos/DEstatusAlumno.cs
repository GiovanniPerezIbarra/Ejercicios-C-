using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEstatusAlumno
    {
        private InstitutoTichEntities dbcontext = new InstitutoTichEntities();
        public List<EstatusAlumnos> Consultar()
        {
            List<EstatusAlumnos> estatus = dbcontext.EstatusAlumnos.ToList();
            return estatus;
        }
    }
}
