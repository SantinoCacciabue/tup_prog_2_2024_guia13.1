using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act.models
{
    internal class Ticket
    {
        protected int nroOrden;
        private DateTime fechaHora = DateTime.Now;
        public int VerNro()
        {
            return nroOrden;
        }
        public DateTime VerFechaHora()
        {
            return fechaHora;
        }
    }
}
