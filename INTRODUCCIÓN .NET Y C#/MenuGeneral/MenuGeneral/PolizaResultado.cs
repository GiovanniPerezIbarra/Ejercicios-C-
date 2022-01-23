using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public struct PolizaResultado
    {
        public DateTime fechaTermino;
        public decimal Prima;
        public PolizaResultado(DateTime fechaTer, decimal Prim)
        {
            this.fechaTermino = fechaTer;
            this.Prima = Prim;
        }
    }
}