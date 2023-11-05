using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRogelike.Modelo.Objetos
{
    internal class Equipamiento : Objeto
    {
        private bool Equipable;

        public Equipamiento(int id, string tipo, string nombre, int danio, string texto) : base(id, tipo, nombre, danio, texto)
        {
        }

        public bool Equipable1 { get => Equipable; set => Equipable = value; }

        public override bool Equals(object? obj)
        {
            return obj is Equipamiento equipamiento &&
                   base.Equals(obj) &&
                   Equipable == equipamiento.Equipable;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Equipable);
        }
    }
}
