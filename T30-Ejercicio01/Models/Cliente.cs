using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T30_Ejercicio01.Models
{
    internal class Cliente
    {
        //ATRIBUTOS
        public int id { get; set; }
        public string name { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public int dni { get; set; }
        public DateTime fecha { get; set; }
    }
}
