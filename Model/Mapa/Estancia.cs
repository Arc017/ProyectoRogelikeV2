using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRogelike.Modelo.Mapa
{
    internal class Estancia
    {
        private int Id;
        private string Tipo;
        private string Texto;

        public Estancia(int id, string tipo, string texto)
        {
            Id1 = id;
            Tipo1 = tipo;
            Texto = texto;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Texto1 { get => Texto; set => Texto = value; }

        public override bool Equals(object? obj)
        {
            return obj is Estancia estancia &&
                   Id == estancia.Id &&
                   Tipo == estancia.Tipo &&
                   Texto == estancia.Texto;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Tipo, Texto);
        }
    }
}
