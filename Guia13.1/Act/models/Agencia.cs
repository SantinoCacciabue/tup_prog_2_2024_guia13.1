using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act.models
{
    internal class Agencia
    {
        private Queue<Denuncia> denuncias = new Queue<Denuncia>();
        private Queue<Cliente> nuevos = new Queue<Cliente>();
        public List<Vehiculo> vehiculos = new List<Vehiculo>();
        public List<Ticket> atendidos = new List<Ticket>();
        public void AgregarTicket(Ticket turno)
        {
            if(turno is Denuncia)
            {
                denuncias.Enqueue(turno as Denuncia);
            }
            if(turno is Cliente)
            {
                nuevos.Enqueue(turno as Cliente);
            }
        }
        public Ticket AtenderTicket(int tipo)
        {
            Ticket t = null;
            if(tipo == 0)
            {
                if(denuncias.Count > 0)
                {
                    t = denuncias.Dequeue();
                }
                
            }
            if (tipo == 1)
            {
                if(nuevos.Count > 0)
                {
                    t = nuevos.Dequeue();               
                }
            }
            if(t!= null)
            {
                atendidos.Add(t);
            }
            return t;
        }
        public Vehiculo BuscarVehiculo(string patente)
        {
            vehiculos.Sort();
            int i = vehiculos.BinarySearch(new Vehiculo(patente));
            if (i >= 0)
            {
                return vehiculos[i];
            }
            return null;
        }
        public void AgregarVehiculo(Vehiculo v)
        {
            if (v != null)
            {
                vehiculos.Add(v);
            }
        }
    }
}
