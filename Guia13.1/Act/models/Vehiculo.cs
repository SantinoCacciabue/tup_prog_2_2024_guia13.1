using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act.models
{
    internal class Vehiculo:IComparable<Vehiculo>
    {
        public string patente;
        private Cliente dueño;
        public Vehiculo(string patente, Cliente dueño)
        {
            this.patente = patente;
            this.dueño = dueño;
        }
        public Vehiculo(string patente)
        {
            this.patente = patente;
        }
        public Cliente VerDueño()
        {
            return dueño;
        }
        public string VerPatente()
        {
            return patente;
        }

        public int CompareTo(Vehiculo o)
        {
            if (o != null)
            {
                return patente.CompareTo(o.patente);
            }
            return -1;
        }
    }
}
