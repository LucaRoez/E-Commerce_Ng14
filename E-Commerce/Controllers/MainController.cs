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
        public IActionResult GetProducts([FromQuery] int init, [FromQuery] int end) => Ok(_Http.GetAllProducts(init, end));
    }
}
