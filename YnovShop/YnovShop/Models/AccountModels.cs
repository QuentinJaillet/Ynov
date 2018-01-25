using System.ComponentModel.DataAnnotations;

namespace YnovShop.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Veuillez indiquer votre prénom")]
        [Display(Name = "Prénom")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Veuillez indiquer votre nom")]
        [Display(Name = "Nom")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Veuillez indiquer votre email")]
        [EmailAddress]
        [Display(Name = "Email")]   
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)] 
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer le mot de passe")]  // todo resource 
        [Compare("Password", ErrorMessage = "Le mot de passe ne correspond pas")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required(ErrorMessage = "Veuillez indiquer votre email")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
