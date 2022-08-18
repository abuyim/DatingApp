using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password required")]
        [MinLength(6, ErrorMessage = "Passord minmum length should be 6")]
        public string Password { get; set; }
    }
}
