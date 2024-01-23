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
        public void Get200_SelectSummerProducts()
        {
            Mock<IHttpService> serviceMock = new();
            serviceMock.Setup(x => x.GetSummerProducts(It.IsAny<int>(), It.IsAny<int>())).Returns(new List<DProduct>());
            MainController systemUnderTest = new(serviceMock.Object);

            var result = systemUnderTest.GetSummerProducts(1, 1) as OkObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);
            result.Value.Should().BeOfType<List<DProduct>>();
        }

        [Fact]
        public void Get200_SelectWinterProducts()
        {
            Mock<IHttpService> serviceMock = new();
            serviceMock.Setup(x => x.GetWinterProducts(It.IsAny<int>(), It.IsAny<int>())).Returns(new List<DProduct>());
            MainController systemUnderTest = new(serviceMock.Object);

            var result = systemUnderTest.GetWinterProducts(1, 1) as OkObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);
            result.Value.Should().BeOfType<List<DProduct>>();
        }

        [Fact]
        public void Get200_SelectCasualProducts()
        {
            Mock<IHttpService> serviceMock = new();
            serviceMock.Setup(x => x.GetCasualProducts(It.IsAny<int>(), It.IsAny<int>())).Returns(new List<DProduct>());
            MainController systemUnderTest = new(serviceMock.Object);

            var result = systemUnderTest.GetCasualProducts(1, 1) as OkObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);
            result.Value.Should().BeOfType<List<DProduct>>();
        }

        [Fact]
        public void Get200_SelectFormalProducts()
        {
            Mock<IHttpService> serviceMock = new();
            serviceMock.Setup(x => x.GetFormalProducts(It.IsAny<int>(), It.IsAny<int>())).Returns(new List<DProduct>());
            MainController systemUnderTest = new(serviceMock.Object);

            var result = systemUnderTest.GetFormalProducts(1, 1) as OkObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);
            result.Value.Should().BeOfType<List<DProduct>>();
        }

        [Fact]
        public void Get200_SelectFashionProducts()
        {
            Mock<IHttpService> serviceMock = new();
            serviceMock.Setup(x => x.GetFashionProducts(It.IsAny<int>(), It.IsAny<int>())).Returns(new List<DProduct>());
            MainController systemUnderTest = new(serviceMock.Object);

            var result = systemUnderTest.GetFashionProducts(1, 1) as OkObjectResult;

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