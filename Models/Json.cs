using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoRogelike.Modelo
{
    internal class Json
    {
        private string RutaArchivo = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\")) + "Recursos/json/jugador.json");

        public Json(string rutaArchivo)
        {
            RutaArchivo1 = rutaArchivo;
        }

        public string RutaArchivo1 { get => RutaArchivo; set => RutaArchivo = value; }
    }
}
