using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEstado
    {
        private InstitutoTichEntities dbcontext = new InstitutoTichEntities();
        public List<Estados> Consultar()
        {
            List<Estados> estados = dbcontext.Estados.ToList();
            return estados;
        }
    }
}