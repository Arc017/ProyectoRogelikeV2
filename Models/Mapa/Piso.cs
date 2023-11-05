using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRogelike.Modelo.Mapa
{
    internal class Piso
    {
        private int Id = 0;
        private string Nombre = "";
        private int NumEstancias = 0;
        private string Texto;

        public Piso(int id, string nombre, int numEstancias, string texto)
        {
            Id1 = id;
            Nombre1 = nombre;
            NumEstancias1 = numEstancias;
            Texto = texto;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int NumEstancias1 { get => NumEstancias; set => NumEstancias = value; }
        public string Texto1 { get => Texto; set => Texto = value; }

        public Piso()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is Piso piso &&
                   Id == piso.Id &&
                   Nombre == piso.Nombre &&
                   NumEstancias == piso.NumEstancias && 
                   Texto == piso.Texto;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nombre, NumEstancias, Texto);
        }
    }
}
