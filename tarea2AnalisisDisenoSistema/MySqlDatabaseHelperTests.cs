using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2AnalisisDisenoSistema
{
    internal class MySqlDatabaseHelperTests
    {
        private readonly Mock<MySqlConnection> _mockConnection;
        private readonly MySqlDatabaseHelper _databaseHelper;

        public MySqlDatabaseHelperTests()
        {
            // Crear un mock de MySqlConnection
            _mockConnection = new Mock<MySqlConnection>();
            _databaseHelper = new MySqlDatabaseHelper();
        }

        [Fact]
        public void OpenConnection_Success_OpensConnection()
        {
            // Arrange
            _mockConnection.Setup(c => c.Open()).Verifiable();
            _mockConnection.Setup(c => c.State).Returns(System.Data.ConnectionState.Open);

            // Act
            var connection = _databaseHelper.OpenConnection();

            // Assert
            _mockConnection.Verify(c => c.Open(), Times.Once);
            Assert.Equal(_mockConnection.Object, connection);
        }

        [Fact]
        public void OpenConnection_Failure_ThrowsException()
        {
            // Arrange
            _mockConnection.Setup(c => c.Open()).Throws(new MySqlException("Connection failed"));

            // Act & Assert
            var exception = Assert.Throws<MySqlException>(() => _databaseHelper.OpenConnection());
            Assert.Equal("Connection failed", exception.Message);
        }

        [Fact]
        public void CloseConnection_ConnectionOpen_ClosesConnection()
        {
            // Arrange
            _mockConnection.Setup(c => c.State).Returns(System.Data.ConnectionState.Open);
            _mockConnection.Setup(c => c.Close()).Verifiable();

            // Act
            _databaseHelper.CloseConnection();

            // Assert
            _mockConnection.Verify(c => c.Close(), Times.Once);
        }

        [Fact]
        public void CloseConnection_ConnectionNotOpen_DoesNotCloseConnection()
        {
            // Arrange
            _mockConnection.Setup(c => c.State).Returns(System.Data.ConnectionState.Closed);

            // Act
            _databaseHelper.CloseConnection();

            // Assert
            _mockConnection.Verify(c => c.Close(), Times.Never);
        }
    }
}
