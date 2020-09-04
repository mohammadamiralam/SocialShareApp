using System.ComponentModel.DataAnnotations;

namespace SocialShareApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify paswword between 4 & 8 characters")]
        public string Password { get; set; }
    }
}