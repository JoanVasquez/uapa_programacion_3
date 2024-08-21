using Moq;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Xunit;

namespace tarea2AnalisisDisenoSistema
{
    internal class BibliotecaServicioTests
    {
        private readonly Mock<MySqlDatabaseHelper> _mockDatabaseHelper;
        private readonly BibliotecaServicio _bibliotecaServicio;

        public BibliotecaServicioTests()
        {
            _mockDatabaseHelper = new Mock<MySqlDatabaseHelper>();
            _bibliotecaServicio = new BibliotecaServicio
            {
                MySqlDatabaseHelper = _mockDatabaseHelper.Object
            };
        }

        [Fact]
        public void ConsultarDisponibilidadLibro_BookAvailable_ReturnsTrue()
        {
            // Arrange
            var libroNombre = "Some Book";
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Rows.Add(1);

            var mockReader = dataTable.CreateDataReader();
            _mockDatabaseHelper.Setup(db => db.OpenConnection()).Returns(new MySqlConnection());
            _mockDatabaseHelper.Setup(db => db.CreateCommand()).Returns(new MySqlCommand());
            _mockDatabaseHelper.Setup(db => db.ExecuteReader()).Returns(mockReader);

            // Act
            var result = _bibliotecaServicio.consultarDisponibilidadLibro(libroNombre);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void GestionarDevolucionLibro_UserHasBook_ReturnsTrue()
        {
            // Arrange
            var libro = new Libro { ID = 1 };
            var usuario = new Usuario { ID = 1 };

            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Rows.Add(1);

            var mockReader = dataTable.CreateDataReader();
            _mockDatabaseHelper.Setup(db => db.OpenConnection()).Returns(new MySqlConnection());
            _mockDatabaseHelper.Setup(db => db.CreateCommand()).Returns(new MySqlCommand());
            _mockDatabaseHelper.Setup(db => db.ExecuteReader()).Returns(mockReader);

            // Act
            var result = _bibliotecaServicio.gestionarDevolucionLibro(libro, usuario);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void GestionPrestamoLibro_BookAvailable_ReturnsSuccessMessage()
        {
            // Arrange
            var libro = new Libro { ID = 1 };
            var usuario = new Usuario { ID = 1 };
            var fechaPrestamo = "2024-01-01";
            var fechaDevolucion = "2024-01-15";

            var mockReader = new Mock<IDataReader>();
            mockReader.Setup(r => r.Read()).Returns(true).Callback(() => mockReader.Setup(r => r.Read()).Returns(false));

            _mockDatabaseHelper.Setup(db => db.OpenConnection()).Returns(new MySqlConnection());
            _mockDatabaseHelper.Setup(db => db.CreateCommand()).Returns(new MySqlCommand());
            _mockDatabaseHelper.Setup(db => db.ExecuteReader()).Returns(mockReader.Object);

            // Act
            var result = _bibliotecaServicio.gestionPrestamoLibro(libro, usuario, fechaPrestamo, fechaDevolucion);

            // Assert
            Assert.Equal("Libro Prestado", result);
        }

        [Fact]
        public void ListarLibros_ReturnsListOfBooks()
        {
            // Arrange
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("TITLE", typeof(string));
            dataTable.Columns.Add("EDITORIAL", typeof(string));
            dataTable.Columns.Add("GENERO", typeof(string));
            dataTable.Columns.Add("FECHA_PUBLICACION", typeof(string));
            dataTable.Rows.Add(1, "Book Title", "Publisher", "Genre", "2024-01-01");

            var mockReader = dataTable.CreateDataReader();
            _mockDatabaseHelper.Setup(db => db.OpenConnection()).Returns(new MySqlConnection());
            _mockDatabaseHelper.Setup(db => db.CreateCommand()).Returns(new MySqlCommand());
            _mockDatabaseHelper.Setup(db => db.ExecuteReader()).Returns(mockReader);

            // Act
            var result = _bibliotecaServicio.listarLibros();

            // Assert
            Assert.Single(result);
            Assert.Equal("Book Title", result[0].Title);
        }

        [Fact]
        public void ListarUsuarios_ReturnsListOfUsers()
        {
            // Arrange
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("NOMBRE", typeof(string));
            dataTable.Columns.Add("EMAIL", typeof(string));
            dataTable.Columns.Add("TELEFONO", typeof(string));
            dataTable.Columns.Add("DIRECCION", typeof(string));
            dataTable.Rows.Add(1, "User Name", "user@example.com", "1234567890", "Address");

            var mockReader = dataTable.CreateDataReader();
            _mockDatabaseHelper.Setup(db => db.OpenConnection()).Returns(new MySqlConnection());
            _mockDatabaseHelper.Setup(db => db.CreateCommand()).Returns(new MySqlCommand());
            _mockDatabaseHelper.Setup(db => db.ExecuteReader()).Returns(mockReader);

            // Act
            var result = _bibliotecaServicio.listarUsuarios();

            // Assert
            Assert.Single(result);
            Assert.Equal("User Name", result[0].Nombre);
        }

        [Fact]
        public void RegistrarLibro_Success_ReturnsBookWithId()
        {
            // Arrange
            var libro = new Libro
            {
                Title = "New Book",
                Editorial = "New Publisher",
                Genero = "New Genre",
                FechaPublicacion = "2024-01-01"
            };

            _mockDatabaseHelper.Setup(db => db.OpenConnection()).Returns(new MySqlConnection());
            _mockDatabaseHelper.Setup(db => db.CreateCommand()).Returns(new MySqlCommand());
            _mockDatabaseHelper.Setup(db => db.ExecuteNonQuery()).Returns(1);
            _mockDatabaseHelper.Setup(db => db.LastInsertedId).Returns(1);

            // Act
            var result = _bibliotecaServicio.registrarLibro(libro);

            // Assert
            Assert.Equal(1, result.ID);
        }

        [Fact]
        public void RegistrarUsuario_NotImplemented_ThrowsNotImplementedException()
        {
            // Arrange
            var usuario = new Usuario();

            // Act & Assert
            Assert.Throws<NotImplementedException>(() => _bibliotecaServicio.registrarUsuario(usuario));
        }
    }
}
