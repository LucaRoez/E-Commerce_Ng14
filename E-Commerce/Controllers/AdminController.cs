﻿using E_Commerce.Models;
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
        public async Task<IActionResult> PostProduct([FromBody] Product product)
        {
            string response = await _Http.PostProduct(product);
            return Ok(response);
        }

        [HttpPost]
        [Route("admin/gender")]
        public async Task<IActionResult> PostGender([FromBody] Gender gender)
        {
            string response = await _Http.PostGender(gender);
            return Ok(response);
        }

        [HttpPost]
        [Route("admin/category")]
        public async Task<IActionResult> PostCategory([FromBody] Category category)
        {
            string response = await _Http.PostCategory(category);
            return Ok(response);
        }

        [HttpPost]
        [Route("admin/currency")]
        public async Task<IActionResult> PostCurrency([FromBody] Currency currency)
        {
            string response = await _Http.PostCurrency(currency);
            return Ok(response);
        }
    }
}
