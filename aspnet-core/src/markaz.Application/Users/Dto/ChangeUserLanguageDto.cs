using System.ComponentModel.DataAnnotations;

namespace markaz.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}