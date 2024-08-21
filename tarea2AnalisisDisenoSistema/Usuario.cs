using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2AnalisisDisenoSistema
{
    internal class Usuario
    {
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;
        private string email;

        public int ID { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}
