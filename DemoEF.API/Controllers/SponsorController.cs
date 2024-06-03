using DemoEF.API.DTO;
using DemoEF.BLL.Interfaces.Services;
using DemoEF.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoEF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SponsorController(ISponsorService sponsorService) : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromForm]AddSponsorForm form)
        {
            MemoryStream stream = new MemoryStream();
            form.LogoFile.CopyTo(stream);
            byte[] bytes = stream.ToArray();
            Sponsor sponsor = new Sponsor
            {
                Name = form.Name,
                Logo = bytes,
                MimeType = form.LogoFile.ContentType,
            };
            sponsorService.AddSponsor(sponsor);
            return NoContent();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(sponsorService.GetAll().Select(s => new SponsorDTO(s)));
        }

        [HttpGet("{sponsorId}/image")]
        public IActionResult ImageUrl(int sponsorId)
        {
            try
            {
                Sponsor sponsor = sponsorService.GetById(sponsorId);
                return File(sponsor.Logo, sponsor.MimeType);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
