using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using ProyectoRogelike.Modelo.Personajes;
using System.Xml.Linq;
using ProyectoRogelike.Controlador.Almacenaje;
using ProyectoRogelike.Modelo;

namespace ProyectoRogelike.Controlador.Personajes
{
    public class ControladorPersonajes<T> where T : class
    {
        List<Jugador> infJugador = new List<Jugador>();
        List<Enemigo> infEnemigo = new List<Enemigo>();
        ControladorJson cj = new ControladorJson();


        //recopilar informacion
        public void CargarJugador()
        {

            List<dynamic> listaPersonajes = cj.PersonajesALista();
            foreach(var elemento in listaPersonajes)
            {
                if(elemento.Hambre1 != null)
                {
                    infJugador.Add(JsonConvert.DeserializeObject<Jugador>(elemento.ToString()));
                }
            }
        }
        public void CargarEnemigo()
        {

            List<dynamic> listaPersonajes = cj.PersonajesALista();
            foreach (var elemento in listaPersonajes)
            {
                if (elemento.Id1 != null)
                {
                    infEnemigo.Add(JsonConvert.DeserializeObject<Enemigo>(elemento.ToString()));
                }
            }
        }




        //Monstruos
        public void MostrarInfoMonstruos()
        {
            CargarEnemigo();
            foreach (var elemento in infEnemigo)
            {
                Console.WriteLine("Id: " + elemento.Id1 + " Nombre: " + elemento.Nombre1 + " Descripcion: " + elemento.Descripcion_1 + " Debilidad: " + elemento.Debilidad1 + " Vida: " 
                    + elemento.Vida1 + " Daño: " + elemento.Danio1 + " Turno: " + elemento.Turno1);
            }
        }


        //Jugador
        public void MostrarInfoJugador()
        {
            CargarJugador();
            foreach (var elemento in infJugador)
            {
                Console.WriteLine("Vida: " + elemento.Vida1 + " Daño: " + elemento.Danio1 + " Turno: " + elemento.Turno1 + " Hambre: " + elemento.Hambre1);
            }
        }

        //List<Jugador> infJugador = new List<Jugador>();

        //public void DaniarJugador()
        //{
        //    int danioEntrante = 0;
        //    Console.WriteLine("Daño??");
        //    danioEntrante = int.Parse(Console.ReadLine());

        //    infJugador[0].Vida1 = infJugador[0].Vida1 - danioEntrante;

        //}
        //public void DisminuirHambre()
        //{
        //    int ciclo = 0;
        //    int hambre = 0;

        //    if (ciclo != 10)
        //    {
        //        while (ciclo < 10)
        //        {
        //            ciclo++;
        //        }
        //        hambre++;
        //    }
        //    else
        //    {
        //        foreach (Jugador j in infJugador)
        //        {
        //            j.Hambre1 -= hambre;
        //            Console.WriteLine("hambre actual: " + j.Hambre1);
        //        }
        //    }



        //}


        //public void MostrarInventario()
        //{

        //}


        ////Json a otra parte
        //public void AlmacenarInfJugador()
        //{
        //    string proyectoPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
        //    string RutaArchivo = Path.Combine(proyectoPath, "Recursos/json/jugador.json");

        //    string GuardarJson = JsonConvert.SerializeObject(infJugador, Formatting.Indented);

        //    File.WriteAllText(RutaArchivo, GuardarJson);

        //    Console.WriteLine("Información de jugadores almacenada en " + RutaArchivo);
        //}
        //public void InfJugadorALista()
        //{
        //    string proyectoPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
        //    string RutaArchivo = Path.Combine(proyectoPath, "Recursos/json/jugador.json");

        //    if (File.Exists(RutaArchivo))
        //    {
        //        string json = File.ReadAllText(RutaArchivo);

        //        // Deserializa el JSON en la lista infJugador
        //        infJugador = JsonConvert.DeserializeObject<List<Jugador>>(json);

        //        Console.WriteLine("Información de jugadores cargada desde " + RutaArchivo);
        //    }
        //    else
        //    {
        //        Console.WriteLine("El archivo " + RutaArchivo + " no existe. La lista infJugador no se actualizó.");
        //    }

        //}

    }
}
