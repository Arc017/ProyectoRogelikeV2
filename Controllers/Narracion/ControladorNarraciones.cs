using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ProyectoRogelike.Modelo.Narracion;

namespace ProyectoRogelike.Controlador.ControladorNarracion
{
    internal class ControladorNarraciones
    {

        List<Narracion> TNarraciones = new List<Narracion>();

        public ControladorNarraciones(List<Narracion> tNarraciones)
        {
            TNarraciones = tNarraciones;
        }
        public ControladorNarraciones()
        {
        }

        public void IniciarNarracion()
        {
            Narracion n1 = new Narracion(0, "Vienvenido sea usted....");
            Narracion n2 = new Narracion(1, "El pasillo se derrumba a tus espaldas");
            Narracion n3 = new Narracion(2, "has encontrado un cofre");

            TNarraciones.Add(n1);
            TNarraciones.Add(n2);
            TNarraciones.Add(n3);
        }

        public void GenerarNarracion()
        {
        }

        public void MostrarNarraciones()
        {
            foreach (var elemento in TNarraciones)
            {
                if (elemento != null)
                {
                    Console.WriteLine(elemento.Texto1);
                }
            }
        }

    }
}
