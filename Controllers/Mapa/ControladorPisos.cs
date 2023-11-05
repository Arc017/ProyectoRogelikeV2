using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoRogelike.Modelo.Mapa;

namespace ProyectoRogelike.Controlador.Mapa
{
    internal class ControladorPisos
    {
        List<Piso> ListaPisos = new List<Piso>();

        public ControladorPisos(List<Piso> listaPisos)
        {
            ListaPisos = listaPisos;
        }
        public ControladorPisos()
        {
        }

        public void iniciarPiso()
        {
            //Piso p1 = new Piso(0, "alcantarillado", 5);
            //Piso p2 = new Piso(1, "Mazmorra", 8);

            //ListaPisos.Add(p1);
            //ListaPisos.Add(p2);
        }

        public void CrearPiso()
        {
            int nuevaId = 0;
            string nombre = " ";
            int cantidadEstancias = 0;

            foreach (var elemento in ListaPisos)
            {
                Console.WriteLine(elemento.Nombre1 + ", " + elemento.Id1 + ", " + elemento.NumEstancias1);
            }
        }
        public void generarPisos()
        {

        }
        public void generarMapa()
        {

        }
    }
}
