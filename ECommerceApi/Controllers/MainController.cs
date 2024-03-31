using ECommerceApi.Services.Utilities;
using ECommerceApi.Models.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    [ApiController]
    public class MainController : Controller
    {
        private readonly ResponseManager _Http;
        public MainController(ResponseManager http)
        {
            _Http = http;
        }

        [HttpGet]
        [Route("products/{id}")]
        public IActionResult GetProduct(int id)
        {
            Response result = _Http.ReturnProductResponse(id);
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

        [HttpGet]
        [Route("products")]
        public IActionResult GetAllProducts(int init, int length)
        {
            Response result = _Http.ReturnAllProductsResponse(init, length);
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

        [HttpGet]
        [Route("products/male")]
        public IActionResult GetMaleProducts(int init, int length)
        {
            Response result = _Http.ReturnMaleProductsResponse(init, length);
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

        [HttpGet]
        [Route("products/female")]
        public IActionResult GetFemaleProducts(int init, int length)
        {
            Response result = _Http.ReturnFemaleProductsResponse(init, length);
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

        [HttpGet]
        [Route("products/babyfashion")]
        public IActionResult GetBabyProducts(int init, int length)
        {
            Response result = _Http.ReturnBabyProductsResponse(init, length);
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

        [HttpGet]
        [Route("products/summer")]
        public IActionResult GetSummerProducts(int init, int length)
        {
            Response result = _Http.ReturnSummerProductsResponse(init, length);
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

        [HttpGet]
        [Route("products/winter")]
        public IActionResult GetWinterProducts(int init, int length)
        {
            Response result = _Http.ReturnWinterProductsResponse(init, length);
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

        [HttpGet]
        [Route("products/casual")]
        public IActionResult GetCasualProducts(int init, int length)
        {
            Response result = _Http.ReturnCasualProductsResponse(init, length);
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

        [HttpGet]
        [Route("products/formal")]
        public IActionResult GetFormalProducts(int init, int length)
        {
            Response result = _Http.ReturnFormalProductsResponse(init, length);
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

        [HttpGet]
        [Route("products/fashion")]
        public IActionResult GetFashionProducts(int init, int length)
        {
            Response result = _Http.ReturnFashionProductsResponse(init, length);
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

        [HttpGet]
        [Route("products/search")]
        public IActionResult GetFilteredProducts(string? genderFilter, string? categoryFilter)
        {
            Response result = _Http.ReturnFilteredProductsResponse(genderFilter, categoryFilter);
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

        [HttpGet]
        [Route("images/{id}")]
        public IActionResult GetImages(int id)
        {
            Response result = _Http.ReturnImageResponse(id);
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

        [HttpGet]
        [Route("images")]
        public IActionResult GetImages()
        {
            Response result = _Http.ReturnAllImagesResponse();
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

        [HttpGet]
        [Route("genders")]
        public IActionResult GetGenders()
        {
            Response result = _Http.ReturnAllGendersResponse();
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

        [HttpGet]
        [Route("categories")]
        public IActionResult GetCategories()
        {
            Response result = _Http.ReturnAllCategoriesResponse();
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

        [HttpGet]
        [Route("currencies")]
        public IActionResult GetCurrencies()
        {
            Response result = _Http.ReturnAllCurrenciesResponse();
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
