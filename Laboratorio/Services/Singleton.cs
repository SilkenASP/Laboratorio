using Laboratorio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Services
{
    public class Singleton
    {
        private static Singleton current;
        public static Singleton Instance
        {
            get
            {
                if (current==null)
                {
                    current = new Singleton();
                }
                return current;
            }
        }
        public List<Equipo> Equipos { get; set; }
        public List<String> Universidades { get; set; }
        public Equipo EquipoSeleccionado { get; set; }
    }
}