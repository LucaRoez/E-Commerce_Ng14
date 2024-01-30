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

        [HttpPost]
        [Route("products")]
        public IActionResult GetAllProducts(int init, int length) => Ok(_Http.GetAllProducts(init, length));

        [HttpPost]
        [Route("products/male")]
        public IActionResult GetMaleProducts(int init, int length) => Ok(_Http.GetMaleProducts(init, length));

        [HttpPost]
        [Route("products/female")]
        public IActionResult GetFemaleProducts(int init, int length) => Ok(_Http.GetFemaleProducts(init, length));

        [HttpPost]
        [Route("products/babyfashion")]
        public IActionResult GetBabyProducts(int init, int length) => Ok(_Http.GetBabyProducts(init, length));

        [HttpPost]
        [Route("products/summer")]
        public IActionResult GetSummerProducts(int init, int length) => Ok(_Http.GetSummerProducts(init, length));

        [HttpPost]
        [Route("products/winter")]
        public IActionResult GetWinterProducts(int init, int length) => Ok(_Http.GetWinterProducts(init, length));

        [HttpPost]
        [Route("products/casual")]
        public IActionResult GetCasualProducts(int init, int length) => Ok(_Http.GetCasualProducts(init, length));

        [HttpPost]
        [Route("products/formal")]
        public IActionResult GetFormalProducts(int init, int length) => Ok(_Http.GetFormalProducts(init, length));

        [HttpPost]
        [Route("products/fashion")]
        public IActionResult GetFashionProducts(int init, int length) => Ok(_Http.GetFashionProducts(init, length));

        [HttpPost]
        [Route("products/search")]
        public IActionResult GetFilteredProducts(string? genderFilter, string? categoryFilter) => Ok(_Http.GetFilteredProducts(genderFilter, categoryFilter));


        [HttpPost]
        [Route("genders")]
        public IActionResult GetGenders() => Ok(_Http.GetAllGenders());

        [HttpPost]
        [Route("categories")]
        public IActionResult GetCategories() => Ok(_Http.GetAllCategories());

        [HttpPost]
        [Route("currencies")]
        public IActionResult GetCurrencies() => Ok(_Http.GetAllCurrencies());
    }
}
