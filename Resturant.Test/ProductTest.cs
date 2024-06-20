using Moq;
using Resturant.Domain.Entities;
using Resturant.Domain.Interfaces.Products;

namespace Resturant.Test;

public class ProductTest
{
    private readonly Mock<IProduct> _productRepositoryMock;

    public ProductTest()
    {
        _productRepositoryMock = new Mock<IProduct>();
    }

    [Fact]
    public void ProductCreate()
    {
        // Arrange 
        string nombreProducto = "Producto de prueba";
        string descripcionProducto = "Descripción del producto de prueba";
        decimal precioProducto = 10.50m;
        int stockProducto = 10;
        string qr = "qr-code-123";
        string urlImagen = "https://imagen.com/producto.jpg";

        // add
        Producto productoEsperado = new Producto
        {
            Descripcion = descripcionProducto,
            Precio = precioProducto,
            Stock = stockProducto,
            Qr = qr,
            UrlImagen = urlImagen
        };

        // Act
        _productRepositoryMock.Object.Add(productoEsperado);

        // Assert
        _productRepositoryMock.Verify(repo => repo.Add(It.Is<Producto>(p =>
            p.Descripcion == descripcionProducto &&
            p.Precio == precioProducto &&
            p.Stock == stockProducto &&
            p.Qr == qr &&
            p.UrlImagen == urlImagen
        )), Times.Once);

    }

    [Fact]
    public void ProductDelete()
    {
        // Arrange
        int productoId = 1;

        // Act
        _productRepositoryMock.Object.Delete(productoId);

        // Assert
        _productRepositoryMock.Verify(repo => repo.Delete(productoId), Times.Once);
    }

    [Fact]
    public void ProductUpdate()
    {
        // Arrange
        Producto productoActualizado = new Producto
        {
            Id = 1,
            Descripcion = "Descripción actualizada",
            Precio = 12.50m,
            Stock = 5,
            Qr = "qr-code-456",
            UrlImagen = "https://imagen.com/producto-actualizado.jpg"
        };

        // Act
        _productRepositoryMock.Object.Update(productoActualizado);

        // Assert
        _productRepositoryMock.Verify(repo => repo.Update(It.Is<Producto>(p =>
            p.Id == productoActualizado.Id &&
            p.Descripcion == productoActualizado.Descripcion &&
            p.Precio == productoActualizado.Precio &&
            p.Stock == productoActualizado.Stock &&
            p.Qr == productoActualizado.Qr &&
            p.UrlImagen == productoActualizado.UrlImagen
        )), Times.Once);
    }
}