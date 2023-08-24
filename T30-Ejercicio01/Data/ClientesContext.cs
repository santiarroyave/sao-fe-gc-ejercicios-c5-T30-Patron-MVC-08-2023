using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T30_Ejercicio01.Models;

namespace T30_Ejercicio01.Data
{
    public class ClientesContext: DbContext
    {
        // El modelo se escribe singular "Cliente"
        // Las colecciones se esciben en plural "Clientes" ya que representan todos los datos dentro de ese modelo
        public DbSet<Cliente> Clientes { get; set; }

        // Constructor de EF
        public ClientesContext(DbContextOptions<ClientesContext> options) :base(options) { }
    }
}
