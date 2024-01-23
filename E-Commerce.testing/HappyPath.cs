using E_Commerce.Controllers;
using E_Commerce.Services.HttpCalls;
using Microsoft.AspNetCore.Mvc;
using Moq;
using FluentAssertions;
using E_Commerce.Models;

namespace E_Commerce.testing
{
    public class HappyPath
    {
        [Fact]
        public void Get200_SelectAllProducts()
        {
            Mock<IHttpService> serviceMock = new();
            serviceMock.Setup(x => x.GetAllProducts(It.IsAny<int>(), It.IsAny<int>())).Returns(new List<DProduct>());
            MainController systemUnderTest = new(serviceMock.Object);

            var result = systemUnderTest.GetAllProducts(1, 2) as OkObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);
            result.Value.Should().BeOfType<List<DProduct>>();
        }

        [Fact]
        public void Get200_SelectMaleProducts()
        {
            Mock<IHttpService> serviceMock = new();
            serviceMock.Setup(x => x.GetMaleProducts(It.IsAny<int>(), It.IsAny<int>())).Returns(new List<DProduct>());
            MainController systemUnderTest = new(serviceMock.Object);

            var result = systemUnderTest.GetMaleProducts(1, 1) as OkObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);
            result.Value.Should().BeOfType<List<DProduct>>();
        }

        [Fact]
        public void Get200_SelectFemaleProducts()
        {
            Mock<IHttpService> serviceMock = new();
            serviceMock.Setup(x => x.GetFemaleProducts(It.IsAny<int>(), It.IsAny<int>())).Returns(new List<DProduct>());
            MainController systemUnderTest = new(serviceMock.Object);

            var result = systemUnderTest.GetFemaleProducts(1, 1) as OkObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);
            result.Value.Should().BeOfType<List<DProduct>>();
        }

        [Fact]
        public void Get200_SelectBabyProducts()
        {
            Mock<IHttpService> serviceMock = new();
            serviceMock.Setup(x => x.GetBabyProducts(It.IsAny<int>(), It.IsAny<int>())).Returns(new List<DProduct>());
            MainController systemUnderTest = new(serviceMock.Object);

            var result = systemUnderTest.GetBabyProducts(1, 1) as OkObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);
            result.Value.Should().BeOfType<List<DProduct>>();
        }

        [Fact]
        public void Get200_SelectFilteredProducts()
        {
            Mock<IHttpService> serviceMock = new();
            serviceMock.Setup(x => x.GetFilteredProducts(It.IsAny<string>(), It.IsAny<string>())).Returns(new List<DProduct>());
            MainController systemUnderTest = new(serviceMock.Object);

            var result = systemUnderTest.GetFilteredProducts("Male","Summer") as OkObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);
            result.Value.Should().BeOfType<List<DProduct>>();
        }
    }
}