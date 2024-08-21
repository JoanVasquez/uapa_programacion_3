using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2AnalisisDisenoSistema
{
    internal interface IBiblioteca
    {
        List<Libro> listarLibros();
        List<Usuario> listarUsuarios();
        Libro registrarLibro(Libro libro);
        Usuario registrarUsuario(Usuario usuario);
        bool consultarDisponibilidadLibro(string libroNombre);
        string gestionPrestamoLibro(Libro libro, Usuario usuario, string fechaPrestamo, string fechaDevolucion);
        bool gestionarDevolucionLibro(Libro libro, Usuario usuario);

    }
}
