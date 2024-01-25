using E_Commerce.Repository.Entities;
using E_Commerce.Services.HttpCalls;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class AdminController : Controller
    {
        private readonly IHttpService _Http;
        public AdminController(IHttpService http)
        {
            _Http = http;
        }

        [HttpPost]
        [Route("admin/product")]
        public async Task<IActionResult> PostProduct([FromQuery] DProduct product)
        {
            string response = await _Http.PostProduct(product);
            return Ok(response);
        }

        [HttpPost]
        [Route("admin/gender")]
        public async Task<IActionResult> PostGender([FromQuery] CGender gender)
        {
            string response = await _Http.PostGender(gender);
            return Ok(response);
        }

        [HttpPost]
        [Route("admin/category")]
        public async Task<IActionResult> PostCategory([FromQuery] CCategory category)
        {
            string response = await _Http.PostCategory(category);
            return Ok(response);
        }
    }
}
