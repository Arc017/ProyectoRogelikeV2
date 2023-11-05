using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRogelike.Modelo.Personajes
{
    internal class Enemigo : Personaje
    {
        private int Id;
        private string Nombre;
        private string Debilidad;
        private string Descripcion;
        public Enemigo(int vida, int danio, bool turno, int Id, string Nombre, string Debilidad, string descripcion1) : base(vida, danio, turno)
        {

        }

        public int Id1 { get => Id; set => Id = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Debilidad1 { get => Debilidad; set => Debilidad = value; }
        public string Descripcion_1 { get => Descripcion; set => Descripcion = value; }

        public override bool Equals(object? obj)
        {
            return obj is Enemigo enemigo &&
                   base.Equals(obj) &&
                   Id == enemigo.Id &&
                   Nombre == enemigo.Nombre &&
                   Debilidad == enemigo.Debilidad &&
                   Descripcion == enemigo.Descripcion;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Id, Nombre, Debilidad, Descripcion);
        }
    }
}
