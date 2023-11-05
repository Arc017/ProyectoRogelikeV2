using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRogelike.Modelo.Objetos
{
    abstract class Objeto
    {
        private int Id;
        private string Tipo;
        private string Nombre;
        private int Danio;
        private string Texto;

        protected Objeto(int id, string tipo, string nombre, int danio, string texto)
        {
            Id1 = id;
            Tipo1 = tipo;
            Nombre1 = nombre;
            Danio1 = danio;
            Texto1 = texto;
            
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Danio1 { get => Danio; set => Danio = value; }
        public string Texto1 { get => Texto; set => Texto = value; }

        public override bool Equals(object? obj)
        {
            return obj is Objeto objeto &&
                   Id == objeto.Id &&
                   Tipo == objeto.Tipo &&
                   Nombre == objeto.Nombre &&
                   Danio == objeto.Danio &&
                   Texto == objeto.Texto;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Tipo, Nombre, Danio, Texto);
        }
    }
}
