using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2AnalisisDisenoSistema
{
    internal class Libro
    {
        private int id;
        private string title;
        private string editorial;
        private string fechaPublicacion;
        private string genero;

        public int ID { get { return id; } set { id = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string Editorial { get { return editorial; } set { editorial = value; } }
        public string FechaPublicacion { get { return fechaPublicacion; } set { fechaPublicacion = value; } }
        public string Genero { get { return genero; } set { genero = value; } }
    }
}
