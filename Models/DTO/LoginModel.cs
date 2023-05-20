using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.DTO
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
