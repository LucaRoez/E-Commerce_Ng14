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
        public IActionResult GetAllProducts([FromQuery] int init, [FromQuery] int length) => Ok(_Http.GetAllProducts(init, length));

        [HttpPost]
        [Route("products/male")]
        public IActionResult GetMaleProducts([FromQuery] int init, [FromQuery] int length) => Ok(_Http.GetMaleProducts(init, length));

        [HttpPost]
        [Route("products/female")]
        public IActionResult GetFemaleProducts([FromQuery] int init, [FromQuery] int length) => Ok(_Http.GetFemaleProducts(init, length));

        [HttpPost]
        [Route("products/babyfashion")]
        public IActionResult GetBabyProducts([FromQuery] int init, [FromQuery] int length) => Ok(_Http.GetBabyProducts(init, length));

        [HttpPost]
        [Route("products/search")]
        public IActionResult GetFilteredProducts([FromQuery] string? genderFilter, [FromQuery] string? categoryFilter) => Ok(_Http.GetFilteredProducts(genderFilter, categoryFilter));
    }
}
