using System.ComponentModel.DataAnnotations;

namespace Users.Models
{
    public class CreateUserViewModel
    {
        // ...
    }

    public class LoginViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }
    }
}