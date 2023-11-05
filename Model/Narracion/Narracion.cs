using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRogelike.Modelo.Narracion
{
    internal class Narracion
    {
        private int Id = 0;
        private string Texto = "";

        public Narracion(int id, string texto)
        {
            Id1 = id;
            Texto1 = texto;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Texto1 { get => Texto; set => Texto = value; }

        public Narracion()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is Narracion narracion &&
                   Id == narracion.Id &&
                   Texto == narracion.Texto;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Texto);
        }
    }
}
