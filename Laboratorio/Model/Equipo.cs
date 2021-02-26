using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Laboratorio.Model
{
    public class Equipo
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Imagen { get; set; }
        public List<Jugador> Jugadores { get; set; }
    }
}