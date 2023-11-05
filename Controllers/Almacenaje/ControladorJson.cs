using ProyectoRogelike.Modelo.Personajes;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ProyectoRogelike.Controlador.Interfaces;
using ProyectoRogelike.Modelo;
using Newtonsoft.Json;

namespace ProyectoRogelike.Controlador.Almacenaje
{
    internal class ControladorJson : IControladorPersonajes
    {
       
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

        public List<dynamic> PersonajesALista()
        {
            string proyectoPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
            string RutaArchivo = Path.Combine(proyectoPath, "Recursos/json/personajes.json");

            List<dynamic> personajes = new();

            if (File.Exists(RutaArchivo))
            {
                string json = File.ReadAllText(RutaArchivo);
                personajes = JsonConvert.DeserializeObject<List<dynamic>>(json);
            }

            return personajes;
        }

    }
}
