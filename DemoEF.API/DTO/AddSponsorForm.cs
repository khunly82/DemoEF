using DemoEF.API.Validators;

namespace DemoEF.API.DTO
{
    public class AddSponsorForm
    {
        public string Name { get; set; } = null!;

        [ImageFileValidator]
        public IFormFile LogoFile { get; set; } = null!;
    }
}
