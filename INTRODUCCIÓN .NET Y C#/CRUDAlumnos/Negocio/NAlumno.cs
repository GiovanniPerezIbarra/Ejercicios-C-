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

        public List<Alumno> Consultar() => _dAlumno.Consultar();

        public Alumno Consultar(int id) => _dAlumno.Consultar(id);

        public void Eliminar(int id) => _dAlumno.Eliminar(id);
        public TablaISR CalcularISR(int id)
        {
            List<TablaISR> list = _dAlumno.ConsultarTablaISR();
            Alumno nuevoalum = Consultar(id);
            decimal quincenal = nuevoalum.sueldo / 2;
            var foundsueldo = from found in list
                              where quincenal >= found.límiteInferior && quincenal <= found.límiteSuperior
                              select new TablaISR { límiteInferior = found.límiteInferior,
                                                    límiteSuperior = found.límiteSuperior,
                                                    cuotaFija = found.cuotaFija,
                                                    excedente = found.excedente,
                                                    subsidio = found.subsidio,
                                                    impuesto = ((((quincenal) - found.límiteInferior) *
                                                    (found.excedente / 100)) + found.cuotaFija) - found.subsidio};
            var objetoisr = foundsueldo.FirstOrDefault();
            return objetoisr;
        }
        public AportacionesIMSS CalcularIMSS(int id)
        {
            Alumno nuevoalum = Consultar(id);
            decimal sbc = nuevoalum.sueldo;
            decimal uma = 2925.09m;
            AportacionesIMSS aport = new AportacionesIMSS();
            {
                aport.enfermedadMaternidad = (sbc - (uma * 3)) * 0.004m;
                aport.invalidezVida = sbc * 0.00625m;
                aport.retiro = sbc * 0m;
                aport.cesantía = sbc * 0.01125m;
                aport.infonavit = sbc * 0m;
            }
           return aport;
        }
    }
}