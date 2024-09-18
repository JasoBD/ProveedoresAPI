
using ProveedoresApi.Models;
using System;
using Xunit;

namespace ProveedoresApi.Tests
{
  
    public class ProveedorTests
    {
        [Fact]
        public void Proveedor_Creation_Should_Set_Properties()
        {
            // Arrange
            var proveedor = new Proveedor
            {
                NIT = "123456789",
                RazonSocial = "Proveedor S.A.",
                Direccion = "Calle Falsa 123",
                Ciudad = "Ciudad Falsa",
                Departamento = "Departamento Falso",
                Correo = "contacto@proveedor.com",
                Activo = true,
                FechaCreacion = DateTime.Now,
                NombreContacto = "Juan Perez",
                CorreoContacto = "juan.perez@proveedor.com"
            };

            // Act & Assert
            Assert.Equal("123456789", proveedor.NIT);
            Assert.Equal("Proveedor S.A.", proveedor.RazonSocial);
            Assert.Equal("Calle Falsa 123", proveedor.Direccion);
            Assert.Equal("Ciudad Falsa", proveedor.Ciudad);
            Assert.Equal("Departamento Falso", proveedor.Departamento);
            Assert.Equal("contacto@proveedor.com", proveedor.Correo);
            Assert.True(proveedor.Activo);
            Assert.NotNull(proveedor.FechaCreacion);
            Assert.Equal("Juan Perez", proveedor.NombreContacto);
            Assert.Equal("juan.perez@proveedor.com", proveedor.CorreoContacto);
        }
    }

}
