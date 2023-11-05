using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRogelike.Modelo.Cofres
{
    internal class Cofre
    {
        private int Id;
        private string Tipo;
        private string Texto;

        public Cofre(int id, string tipo, string texto)
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
            return obj is Cofre cofre &&
                   Id == cofre.Id &&
                   Tipo == cofre.Tipo && 
                   Texto == cofre.Texto;  
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Tipo, Texto);
        }
    }
}
