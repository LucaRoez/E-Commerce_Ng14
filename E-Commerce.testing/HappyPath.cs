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
            MainController systemUnderTest = new(serviceMock.Object);

            var result = systemUnderTest.GetAllProducts(1, 2) as OkObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);
            result.Value.Should().BeOfType<List<DProduct>>();
        }
    }
}