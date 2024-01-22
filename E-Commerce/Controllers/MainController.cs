using E_Commerce.Repository;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class MainController : Controller
    {
        private readonly ICommercialContext _DbContext;
        public MainController(ICommercialContext dbContext)
        {
            _DbContext = dbContext;
        }

        [HttpPost("selectinentity")]
        public async Task<IActionResult> SelectInEntity(Entity entity)
        {
            string[] response = await _DbContext.SelectInOldEntity(entity);
            var finalResponse = new
            {
                StatusMessage = response[0],
                Data = response.Skip(1).ToArray()
            };
            return Ok(finalResponse);
        }
    }
}
