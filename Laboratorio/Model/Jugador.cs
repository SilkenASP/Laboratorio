using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Laboratorio.Model
{
    public class Jugador
    {
        public int id_Jugador { get; set; }
        public String Nombre { get; set; }
        public String Posicion { get; set; }
        public String Fotografia { get; set; }
        public int Edad { get; set; }
        public double EstaturaMetros { get; set; }
        public double Peso { get; set; }
        public String Universidad { get; set; }

    }
}