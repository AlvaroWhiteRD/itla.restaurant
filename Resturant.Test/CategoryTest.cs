using Moq;
using Resturant.Domain.Entities;
using Resturant.Domain.Interfaces.Categorys;


namespace Resturant.Test;

public class CategoryTest
{
    private readonly Mock<ICategory> _categoryRepositoryMock;

    public CategoryTest()
    {
        _categoryRepositoryMock = new Mock<ICategory>();
    }

    [Fact]
    public void CategoryCreate()
    {
        // Arrange 
        string descripcion = "Descripción de la categoria";

        // add
        Categoria categoryEsperada = new Categoria
        {
            Descripcion = descripcion,
        };

        // Act
        _categoryRepositoryMock.Object.Add(categoryEsperada);

        // Assert
        _categoryRepositoryMock.Verify(repo => repo.Add(It.Is<Categoria>(p =>
            p.Descripcion == categoryEsperada.Descripcion
        )), Times.Once);

    }

    [Fact]
    public void CategoryDelete()
    {
        // Arrange
        int caegoryId = 1;

        // Act
        _categoryRepositoryMock.Object.Delete(caegoryId);

        // Assert
        _categoryRepositoryMock.Verify(repo => repo.Delete(caegoryId), Times.Once);
    }

    [Fact]
    public void CategoryUpdate()
    {
        // Arrange
        Categoria categoryUpdate = new Categoria
        {
            Descripcion = "categoria actualizada",
        };

        // Act
        _categoryRepositoryMock.Object.Update(categoryUpdate);

        // Assert
        _categoryRepositoryMock.Verify(repo => repo.Update(It.Is<Categoria>(p =>
            p.Descripcion == categoryUpdate.Descripcion
        )), Times.Once);
    }
}