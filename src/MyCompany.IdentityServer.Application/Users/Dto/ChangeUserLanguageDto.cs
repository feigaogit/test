using System.ComponentModel.DataAnnotations;

namespace MyCompany.IdentityServer.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}