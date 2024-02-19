using ECommerce.Models;
using ECommerce.Services.HttpCalls;
using ECommerce.Services.Utilities;
using ECommerceApi.Models.Http;
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
            Response result = new();
            string response = await _Http.PostProduct(product);
            result.IsSuccessful = Verifications.IsSuccessful(response) ? true : false;
            result.Message = Verifications.IsSuccessful(response) ? "" : response;
            result.StatusCode = Verifications.IsSuccessful(response) ? 200 :
                Verifications.IsNotFound(response) ? 404 :
                Verifications.IsForbidden(response) ? 403 :
                Verifications.IsUnauthorized(response) ? 401 :
                Verifications.IsConflict(response) ? 409 :
                Verifications.IsInternalServerError(response) ? 500 :
                Verifications.IsServiceUnavailable(response) ? 503 :
                Verifications.IsBadRequest(response) ? 400 :
                Verifications.IsUnableToProcess(response) ? 422 : 503;
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

        [EnableCors("CORS_CONFIG")]
        [HttpPost]
        [Route("admin/gender")]
        public async Task<IActionResult> PostGender([FromBody] Gender gender)
        {
            Response result = new();
            string response = await _Http.PostGender(gender);
            result.IsSuccessful = Verifications.IsSuccessful(response) ? true : false;
            result.Message = Verifications.IsSuccessful(response) ? "" : response;
            result.StatusCode = Verifications.IsSuccessful(response) ? 200 :
                Verifications.IsNotFound(response) ? 404 :
                Verifications.IsForbidden(response) ? 403 :
                Verifications.IsUnauthorized(response) ? 401 :
                Verifications.IsConflict(response) ? 409 :
                Verifications.IsInternalServerError(response) ? 500 :
                Verifications.IsServiceUnavailable(response) ? 503 :
                Verifications.IsBadRequest(response) ? 400 :
                Verifications.IsUnableToProcess(response) ? 422 : 503;
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

        [EnableCors("CORS_CONFIG")]
        [HttpPost]
        [Route("admin/category")]
        public async Task<IActionResult> PostCategory([FromBody] Category category)
        {
            Response result = new();
            string response = await _Http.PostCategory(category);
            result.IsSuccessful = Verifications.IsSuccessful(response) ? true : false;
            result.Message = Verifications.IsSuccessful(response) ? "" : response;
            result.StatusCode = Verifications.IsSuccessful(response) ? 200 :
                Verifications.IsNotFound(response) ? 404 :
                Verifications.IsForbidden(response) ? 403 :
                Verifications.IsUnauthorized(response) ? 401 :
                Verifications.IsConflict(response) ? 409 :
                Verifications.IsInternalServerError(response) ? 500 :
                Verifications.IsServiceUnavailable(response) ? 503 :
                Verifications.IsBadRequest(response) ? 400 :
                Verifications.IsUnableToProcess(response) ? 422 : 503;
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

        [EnableCors("CORS_CONFIG")]
        [HttpPost]
        [Route("admin/currency")]
        public async Task<IActionResult> PostCurrency([FromBody] Currency currency)
        {
            Response result = new();
            string response = await _Http.PostCurrency(currency);
            result.IsSuccessful = Verifications.IsSuccessful(response) ? true : false;
            result.Message = Verifications.IsSuccessful(response) ? "" : response;
            result.StatusCode = Verifications.IsSuccessful(response) ? 200 :
                Verifications.IsNotFound(response) ? 404 :
                Verifications.IsForbidden(response) ? 403 :
                Verifications.IsUnauthorized(response) ? 401 :
                Verifications.IsConflict(response) ? 409 :
                Verifications.IsInternalServerError(response) ? 500 :
                Verifications.IsServiceUnavailable(response) ? 503 :
                Verifications.IsBadRequest(response) ? 400 :
                Verifications.IsUnableToProcess(response) ? 422 : 503;
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
