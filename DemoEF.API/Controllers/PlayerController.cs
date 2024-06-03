using DemoEF.DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoEF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController(PlayerRepository playerRepository) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(playerRepository.GetPlayerByTeam(1));
        }
    }
}
