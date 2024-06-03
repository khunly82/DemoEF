using System.ComponentModel.DataAnnotations;

namespace DemoEF.API.Validators
{
    public class ImageFileValidatorAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            IFormFile? file = value as IFormFile;
            if(file is null)
            {
                return true;
            }
            string[] acceptedValues = ["image/jpeg", "image/png"];
            return acceptedValues.Contains(file.ContentType);
        }
    }
}
