using ECommerce.Models;
using ECommerce.Services.HttpCalls;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
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
        public async Task<IActionResult> PostProduct([FromBody] Product product)
        {
            string response = await _Http.PostProduct(product);
            return Ok(response);
        }

        [EnableCors("CORS_CONFIG")]
        [HttpPost]
        [Route("admin/gender")]
        public async Task<IActionResult> PostGender([FromBody] Gender gender)
        {
            string response = await _Http.PostGender(gender);
            return Ok(response);
        }

        [EnableCors("CORS_CONFIG")]
        [HttpPost]
        [Route("admin/category")]
        public async Task<IActionResult> PostCategory([FromBody] Category category)
        {
            string response = await _Http.PostCategory(category);
            return Ok(response);
        }

        [EnableCors("CORS_CONFIG")]
        [HttpPost]
        [Route("admin/currency")]
        public async Task<IActionResult> PostCurrency([FromBody] Currency currency)
        {
            string response = await _Http.PostCurrency(currency);
            return Ok(response);
        }
    }
}
