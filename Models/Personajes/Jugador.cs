using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRogelikeV2.Models.Personajes
{
    internal class Jugador : Personaje
    {

        private int Hambre;

        public Jugador(int vida, int danio, bool turno, int hambre) : base(id, vida, danio, turno)
        {
        }

        public int Hambre1 { get => Hambre; set => Hambre = value; }

        public override bool Equals(object? obj)
        {
            return obj is Jugador jugador &&
                   base.Equals(obj) &&
                   Hambre == jugador.Hambre;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Hambre);
        }
    }
}
