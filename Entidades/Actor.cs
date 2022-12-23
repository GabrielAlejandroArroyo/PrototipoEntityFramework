using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoEntityFramework.Entidades
{
    public class Actor
    {
        public int id { get; set; }
        public string Nombre { get; set; } = null;
        public decimal Fortuna { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}