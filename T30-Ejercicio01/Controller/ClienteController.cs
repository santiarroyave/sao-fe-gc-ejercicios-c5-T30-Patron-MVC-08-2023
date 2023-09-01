using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T30_Ejercicio01.Data;
using T30_Ejercicio01.Models;

namespace T30_Ejercicio01.Controller
{

    internal class ClienteController
    {
        //ATRIBUTOS
        Cliente cliente;
        private ClientesContext context;

        public ClienteController()
        {
            context = new ClientesContext();
        }

        public bool NuevoCliente(string id, string nombre, string apellidos, string direccion, string dni, DateTime fecha)
        {
            //int id;
            //string nombre;
            //string apellidos;
            //string direccion;
            //string dni;
            //DateTime fecha;

            int idInt = int.Parse(id);

            cliente = new Cliente(idInt, nombre, apellidos, direccion, dni, fecha);

            context.Clientes.Add(cliente);
            context.SaveChanges();
            MessageBox.Show("Cliente guardado");

            return true;
        }
    }
}
