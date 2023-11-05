using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProyectoRogelike.Modelo.Personajes
{
    public abstract class Personaje
    {
        [Key]
        private int id;
        private int Vida;
        private int Danio;
        private bool Turno;

        public Personaje(int vida, int danio, bool turno)
        {
            Vida1 = vida;
            Danio1 = danio;
            Turno1 = turno;
        }


        public int Vida1 { get => Vida; set => Vida = value; }
        public int Danio1 { get => Danio; set => Danio = value; }
        public bool Turno1 { get => Turno; set => Turno = value; }


        public override bool Equals(object? obj)
        {
            return obj is Personaje personaje &&
                   Vida == personaje.Vida &&
                   Danio == personaje.Danio &&
                   Turno == personaje.Turno;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Vida, Danio, Turno);
        }
       

    }
}
