using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRogelike.Modelo.Objetos
{
    internal class Consumible : Objeto
    {
        private string Efecto;
        public Consumible(int id, string tipo, string nombre, int danio, string texto) : base(id, tipo, nombre, danio, texto)
        {
        }

        public string Efecto1 { get => Efecto; set => Efecto = value; }

        public override bool Equals(object? obj)
        {
            return obj is Consumible consumible &&
                   base.Equals(obj) &&
                   Efecto == consumible.Efecto;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Efecto);
        }
    }
}
