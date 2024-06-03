using DemoEF.API.DTO;
using DemoEF.BLL.Interfaces.Repositories;
using DemoEF.BLL.Interfaces.Services;
using DemoEF.DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoEF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController(IPlayerService playerService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(playerService.GetAll()
                .Select(p => new PlayerDTO(p)));
        }
    }
}
