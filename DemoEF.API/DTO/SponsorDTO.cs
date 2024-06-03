using DemoEF.Domain.Entities;

namespace DemoEF.API.DTO
{
    public class SponsorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public SponsorDTO(Sponsor sponsor)
        {
            Id = sponsor.Id;
            Name = sponsor.Name;
            LogoUrl = "/api/sponsor/" + Id + "/image";
        }
    }
}
