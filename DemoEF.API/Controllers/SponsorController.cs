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
    }
}
