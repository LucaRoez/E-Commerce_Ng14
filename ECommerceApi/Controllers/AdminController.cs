using ECommerceApi.Models;
using ECommerceApi.Services.Utilities;
using ECommerceApi.Models.Http;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class AdminController : Controller
    {
        private readonly ResponseManager _Http;
        public AdminController(ResponseManager http)
        {
            _Http = http;
        }

        [HttpPost]
        [Route("admin/product")]
        public async Task<IActionResult> PostProduct([FromBody] Product product)
        {
            Response result = await _Http.ReturnResponse(product);
            if (result.StatusCode == 200) return Ok(result);
            else if (result.StatusCode == 404) return NotFound(result);
            else if (result.StatusCode == 403) return Forbid();
            else if (result.StatusCode == 401) return Unauthorized(result);
            else if (result.StatusCode == 409) return Conflict(result);
            else if (result.StatusCode == 500) return StatusCode(500);
            else if (result.StatusCode == 503) return StatusCode(503);
            else if (result.StatusCode == 400) return BadRequest(result);
            else if (result.StatusCode == 422) return StatusCode(422);
            else return StatusCode(503);
        }

        [HttpPost]
        [Route("admin/image")]
        public async Task<IActionResult> PostImage([FromBody] Image image)
        {
            Response result = await _Http.ReturnResponse(image);
            if (result.StatusCode == 200) return Ok(result);
            else if (result.StatusCode == 404) return NotFound(result);
            else if (result.StatusCode == 403) return Forbid();
            else if (result.StatusCode == 401) return Unauthorized(result);
            else if (result.StatusCode == 409) return Conflict(result);
            else if (result.StatusCode == 500) return StatusCode(500);
            else if (result.StatusCode == 503) return StatusCode(503);
            else if (result.StatusCode == 400) return BadRequest(result);
            else if (result.StatusCode == 422) return StatusCode(422);
            else return StatusCode(503);
        }

        [HttpPost]
        [Route("admin/link-image")]
        public async Task<IActionResult> PostLinkForImage([FromBody] Image image, [FromBody] Product product, [FromBody] int slot)
        {
            Response result = await _Http.ReturnResponse(image, product, slot);
            if (result.StatusCode == 200) return Ok(result);
            else if (result.StatusCode == 404) return NotFound(result);
            else if (result.StatusCode == 403) return Forbid();
            else if (result.StatusCode == 401) return Unauthorized(result);
            else if (result.StatusCode == 409) return Conflict(result);
            else if (result.StatusCode == 500) return StatusCode(500);
            else if (result.StatusCode == 503) return StatusCode(503);
            else if (result.StatusCode == 400) return BadRequest(result);
            else if (result.StatusCode == 422) return StatusCode(422);
            else return StatusCode(503);
        }

        [HttpPost]
        [Route("admin/gender")]
        public async Task<IActionResult> PostGender([FromBody] Gender gender)
        {
            Response result = await _Http.ReturnResponse(gender);
            if (result.StatusCode == 200) return Ok(result);
            else if (result.StatusCode == 404) return NotFound(result);
            else if (result.StatusCode == 403) return Forbid();
            else if (result.StatusCode == 401) return Unauthorized(result);
            else if (result.StatusCode == 409) return Conflict(result);
            else if (result.StatusCode == 500) return StatusCode(500);
            else if (result.StatusCode == 503) return StatusCode(503);
            else if (result.StatusCode == 400) return BadRequest(result);
            else if (result.StatusCode == 422) return StatusCode(422);
            else return StatusCode(503);
        }

        [HttpPost]
        [Route("admin/category")]
        public async Task<IActionResult> PostCategory([FromBody] Category category)
        {
            Response result = await _Http.ReturnResponse(category);
            if (result.StatusCode == 200) return Ok(result);
            else if (result.StatusCode == 404) return NotFound(result);
            else if (result.StatusCode == 403) return Forbid();
            else if (result.StatusCode == 401) return Unauthorized(result);
            else if (result.StatusCode == 409) return Conflict(result);
            else if (result.StatusCode == 500) return StatusCode(500);
            else if (result.StatusCode == 503) return StatusCode(503);
            else if (result.StatusCode == 400) return BadRequest(result);
            else if (result.StatusCode == 422) return StatusCode(422);
            else return StatusCode(503);
        }

        [HttpPost]
        [Route("admin/currency")]
        public async Task<IActionResult> PostCurrency([FromBody] Currency currency)
        {
            Response result = await _Http.ReturnResponse(currency);
            if (result.StatusCode == 200) return Ok(result);
            else if (result.StatusCode == 404) return NotFound(result);
            else if (result.StatusCode == 403) return Forbid();
            else if (result.StatusCode == 401) return Unauthorized(result);
            else if (result.StatusCode == 409) return Conflict(result);
            else if (result.StatusCode == 500) return StatusCode(500);
            else if (result.StatusCode == 503) return StatusCode(503);
            else if (result.StatusCode == 400) return BadRequest(result);
            else if (result.StatusCode == 422) return StatusCode(422);
            else return StatusCode(503);
        }
    }
}
