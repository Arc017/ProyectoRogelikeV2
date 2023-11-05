using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRogelike.Modelo.Objetos
{
    internal class Inventario
    {
        private int Id;
        private int CapacidadMax;

        public Inventario(int id, int capacidadMax)
        {
            Id1 = id;
            CapacidadMax1 = capacidadMax;
        }

        public int Id1 { get => Id; set => Id = value; }
        public int CapacidadMax1 { get => CapacidadMax; set => CapacidadMax = value; }

        public override bool Equals(object? obj)
        {
            return obj is Inventario inventario &&
                   Id == inventario.Id &&
                   CapacidadMax == inventario.CapacidadMax;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, CapacidadMax);
        }
    }
}
