using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T30_Ejercicio01.Models
{
    public class Cliente
    {
        //ATRIBUTOS
        [Key]
        [MaxLength(11)]
        public int id { get; set; }

        [MaxLength(250)]
        public string name { get; set; }

        [MaxLength(250)]
        public string apellido { get; set; }

        [MaxLength(250)]
        public string direccion { get; set; }

        [MaxLength(11)]
        public int dni { get; set; }

        public DateTime fecha { get; set; }
    }
}
