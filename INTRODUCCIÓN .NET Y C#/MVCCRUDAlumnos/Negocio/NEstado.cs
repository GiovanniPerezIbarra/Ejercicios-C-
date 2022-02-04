using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEstado
    {
        private DEstado _dEstado;
        public NEstado()
        {
            _dEstado = new DEstado();
        }
        public List<Estados> Consultar() => _dEstado.Consultar();
    }
}