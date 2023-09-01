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
        // ATRIBUTOS
        public int id { get; set; }
        public string name { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string dni { get; set; }
        public DateTime fecha { get; set; }

        // Constructor
        public Cliente(int id, string name, string apellido, string direccion, string dni, DateTime fecha)
        {
            this.id = id;
            this.name = name;
            this.apellido = apellido;
            this.direccion = direccion;
            this.dni = dni;
            this.fecha = fecha;
        }
    }
}
