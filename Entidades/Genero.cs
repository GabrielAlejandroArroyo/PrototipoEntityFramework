using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoEntityFramework.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        //para dejar las anotaciones limpias y traspasarlar al api fluent la ventaja de la anotattions es cuando se consume un framework en el front end, lo valida antes de nviarlos
        //[StringLength(maximumLength: 150)]
        public string Nombre { get; set; } = null!;
    }
}