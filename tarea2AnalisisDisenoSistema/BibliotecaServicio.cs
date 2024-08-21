using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2AnalisisDisenoSistema
{
    internal class BibliotecaServicio : IBiblioteca
    {
        private readonly MySqlDatabaseHelper mySqlDatabaseHelper;

        public BibliotecaServicio()
        {
            mySqlDatabaseHelper = new MySqlDatabaseHelper();
        }

        internal IBiblioteca IBiblioteca
        {
            get => default;
            set
            {
            }
        }

        internal MySqlDatabaseHelper MySqlDatabaseHelper
        {
            get => default;
            set
            {
            }
        }

        internal Libro Libro
        {
            get => default;
            set
            {
            }
        }

        internal Usuario Usuario
        {
            get => default;
            set
            {
            }
        }

        public bool consultarDisponibilidadLibro(string libroNombre)
        {
            try
            {
                string query = "SELECT * FROM TBL_LIBRO WHERE TITULO = @titulo";
                var mySqlCommand = mySqlDatabaseHelper.OpenConnection().CreateCommand();
                mySqlCommand.CommandText = query;
                mySqlCommand.Parameters.AddWithValue("@titulo", libroNombre);

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                int bookId = 0;

                if (reader.Read()) {
                    bookId = Convert.ToInt32(reader["ID"]);
                    reader.Close();
                } else
                {
                    return false;
                }

                string consultaLibroDisponible = "SELECT * FROM TBL_PRESTAMO WHERE ID = @id";
                mySqlCommand.CommandText = consultaLibroDisponible;
                mySqlCommand.Parameters.AddWithValue("@id", bookId);
                reader = mySqlCommand.ExecuteReader();

                if (reader.Read()) { 
                    return false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
                throw;
            }
            finally
            {
                mySqlDatabaseHelper.CloseConnection();
            }
            return true;
        }

        public bool gestionarDevolucionLibro(Libro libro, Usuario usuario)
        {
            try
            {
                bool tieneElUsuarioEseLibro = tieneElUsuarioUnPrestamo(libro, usuario);

                if (tieneElUsuarioEseLibro)
                {
                    string query = "DELETE FROM TBL_PRESTAMO WHERE TBL_LIBRO_ID = @libroId AND TBL_USER_ID = @usuarioId";
                    var mySqlCommand = mySqlDatabaseHelper.OpenConnection().CreateCommand();
                    mySqlCommand.CommandText = query;
                    mySqlCommand.Parameters.AddWithValue("@libroId", libro.ID);
                    mySqlCommand.Parameters.AddWithValue("@usuarioId", usuario.ID);
                    mySqlCommand.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
                throw;
            }
            finally
            {
                mySqlDatabaseHelper.CloseConnection();
            }
            return true;
        }

        public string gestionPrestamoLibro(Libro libro, Usuario usuario, string fechaPrestamo, string fechaDevolucion)
        {
            try
            {
                bool estaElLibroDisponible = consultarDisponibilidadLibro(libro.Title);

                if (estaElLibroDisponible)
                {
                    string query = "INSERT INTO TBL_PRESTAMO (FECHA_PRESTAMO, FECHA_DEVOLUCION, TBL_LIBRO_ID, TBL_USER_ID) VALUES(@fechaPrestamo, @fechaDevolucion, @libroId, @usuarioId)";
                    var mySqlCommand = mySqlDatabaseHelper.OpenConnection().CreateCommand();
                    mySqlCommand.CommandText = query;
                    mySqlCommand.Parameters.AddWithValue("@fechaPrestamo", fechaPrestamo);
                    mySqlCommand.Parameters.AddWithValue("@fechaDevolucion", fechaDevolucion);
                    mySqlCommand.Parameters.AddWithValue("@libroId", libro.ID);
                    mySqlCommand.Parameters.AddWithValue("@usuarioId", usuario.ID);

                    mySqlCommand.ExecuteNonQuery();

                    return "Libro Prestado";
                }
                else
                {
                    return "Libro No Disponible";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
                throw;
            }
            finally
            {
                mySqlDatabaseHelper.CloseConnection();
            }

        }

        public List<Libro> listarLibros()
        {
            var libros = new List<Libro>();
            try
            {
                string query = "SELECT * FROM TBL_LIBRO";
                var mySqlCommand = mySqlDatabaseHelper.OpenConnection().CreateCommand();
                mySqlCommand.CommandText = query;
                var reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    var libro = new Libro()
                    {
                        ID = reader.GetInt32("ID"),
                        Title = reader.GetString("TITLE"),
                        Editorial = reader.GetString("EDITORIAL"),
                        Genero = reader.GetString("GENERO"),
                        FechaPublicacion = reader.GetString("FECHA_PUBLICACION")
                    };
                    libros.Add(libro);
                }
                
            }
            catch (Exception e) {
                MessageBox.Show($"Error: {e.Message}");
                throw;
            }
            finally
            {
                mySqlDatabaseHelper.CloseConnection();
            }
            return libros;
        }

        public List<Usuario> listarUsuarios()
        {
            var usuarios = new List<Usuario>();
            try
            {
                string query = "SELECT * FROM TBL_USUARIO";
                var mySqlCommand = mySqlDatabaseHelper.OpenConnection().CreateCommand();
                mySqlCommand.CommandText = query;
                var reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    var usuario = new Usuario()
                    {
                        ID = reader.GetInt32("ID"),
                        Nombre = reader.GetString("NOMBRE"),
                        Email = reader.GetString("EMAIL"),
                        Telefono = reader.GetString("TELEFONO"),
                        Direccion = reader.GetString("DIRECCION")
                    };
                    usuarios.Add(usuario);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
                throw;
            }
            finally
            {
                mySqlDatabaseHelper.CloseConnection();
            }
            return usuarios;
        }

        public Libro registrarLibro(Libro libro)
        {
            try
            {
                string query = "INSERT INTO TBL_LIBRO(TITULO, EDITORIAL, GENERO, FECHA_PUBLICACION) Values(@titulo, @editorial, @genero, @fecha_publicacion)";
                var mySqlCommand = mySqlDatabaseHelper.OpenConnection().CreateCommand();
                mySqlCommand.CommandText = query;
                mySqlCommand.Parameters.AddWithValue("@titulo", libro.Title);
                mySqlCommand.Parameters.AddWithValue("@editorial", libro.Editorial);
                mySqlCommand.Parameters.AddWithValue("@genero", libro.Genero);
                mySqlCommand.Parameters.AddWithValue("@fecha_publicacion", libro.FechaPublicacion);

                mySqlCommand.ExecuteNonQuery();

                libro.ID = Convert.ToInt32(mySqlCommand.LastInsertedId);

            }
            catch (Exception e) {
                MessageBox.Show($"Error: {e.Message}");
                throw;
            }
            finally
            {
                mySqlDatabaseHelper.CloseConnection();
            }
            return libro;
        }

        public Usuario registrarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        private bool tieneElUsuarioUnPrestamo(Libro libro, Usuario usuario)
        {
            try
            {
                string query = "SELECT * FROM TBL_PRESTAMO WHERE TBL_LIBRO_ID = @libroId AND TBL_USER_ID = @usuarioId";
                var mySqlCommand = mySqlDatabaseHelper.OpenConnection().CreateCommand();
                mySqlCommand.CommandText = query;
                mySqlCommand.Parameters.AddWithValue("libroId", libro.ID);
                mySqlCommand.Parameters.AddWithValue("usuarioId", usuario.ID);

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
                throw;
            }
            finally
            {
                mySqlDatabaseHelper.CloseConnection();
            }

            return false;
        }
    }
}
