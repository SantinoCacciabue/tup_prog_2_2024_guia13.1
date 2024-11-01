using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act.models
{
    internal class Denuncia:Ticket
    {
        private Vehiculo dominio;
        private static int numero;
        public Denuncia(Vehiculo asegurado)
        {
            dominio =asegurado;
            nroOrden = numero++;
        }

    }
}
