using Microsoft.AspNetCore.Mvc;
using Obqva.Domain.Entities;
using Obqva.Service.Services;

namespace Obqva.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdController : ControllerBase
    {
        private readonly IAdService _adService;

        public AdController(IAdService adService)
        {
            _adService = adService;        
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<Ad>> GetById([FromRoute] int id)
        {
            return await _adService.GetAdById(id);
        }

        [HttpGet("/byTitle")]
        public async Task<ActionResult<Ad>> GetByTitle(string title)
        {
            return await _adService.GetAdByTitle(title);
        }
    }
}
