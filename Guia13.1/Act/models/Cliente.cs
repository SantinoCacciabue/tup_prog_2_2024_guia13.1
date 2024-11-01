using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act.models
{
    internal class Cliente:Ticket
    {
        private long dni;
        private static int numero;
        public long VerDNI()
        {
            return dni;
        }
        public Cliente(long dni)
        {
            if (dni > 5000000)
            {
                this.dni = dni;
            }
            else
            {
                throw new DniInvalidoException();
            }           
            nroOrden = numero++;
        }
    }
}
