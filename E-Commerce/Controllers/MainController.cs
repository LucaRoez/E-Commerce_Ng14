using E_Commerce.Services.HttpCalls;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [ApiController]
    public class MainController : Controller
    {
        private readonly IHttpService _Http;
        public MainController(IHttpService http)
        {
            _Http = http;
        }

        [HttpGet]
        [Route("products/{id}")]
        public IActionResult GetProduct(int id) => Ok(_Http.GetProduct(id));

        [HttpGet]
        [Route("products")]
        public IActionResult GetAllProducts(int init, int length) => Ok(_Http.GetAllProducts(init, length));

        [HttpGet]
        [Route("products/male")]
        public IActionResult GetMaleProducts(int init, int length) => Ok(_Http.GetMaleProducts(init, length));

        [HttpGet]
        [Route("products/female")]
        public IActionResult GetFemaleProducts(int init, int length) => Ok(_Http.GetFemaleProducts(init, length));

        [HttpGet]
        [Route("products/babyfashion")]
        public IActionResult GetBabyProducts(int init, int length) => Ok(_Http.GetBabyProducts(init, length));

        [HttpGet]
        [Route("products/summer")]
        public IActionResult GetSummerProducts(int init, int length) => Ok(_Http.GetSummerProducts(init, length));

        [HttpGet]
        [Route("products/winter")]
        public IActionResult GetWinterProducts(int init, int length) => Ok(_Http.GetWinterProducts(init, length));

        [HttpGet]
        [Route("products/casual")]
        public IActionResult GetCasualProducts(int init, int length) => Ok(_Http.GetCasualProducts(init, length));

        [HttpGet]
        [Route("products/formal")]
        public IActionResult GetFormalProducts(int init, int length) => Ok(_Http.GetFormalProducts(init, length));

        [HttpGet]
        [Route("products/fashion")]
        public IActionResult GetFashionProducts(int init, int length) => Ok(_Http.GetFashionProducts(init, length));

        [HttpGet]
        [Route("products/search")]
        public IActionResult GetFilteredProducts(string? genderFilter, string? categoryFilter) => Ok(_Http.GetFilteredProducts(genderFilter, categoryFilter));


        [HttpGet]
        [Route("genders")]
        public IActionResult GetGenders() => Ok(_Http.GetAllGenders());

        [HttpGet]
        [Route("categories")]
        public IActionResult GetCategories() => Ok(_Http.GetAllCategories());

        [HttpGet]
        [Route("currencies")]
        public IActionResult GetCurrencies() => Ok(_Http.GetAllCurrencies());
    }
}
