using System.ComponentModel.DataAnnotations;

namespace Last.Client.Dtos.Login
{
    public class LoginRequestDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
