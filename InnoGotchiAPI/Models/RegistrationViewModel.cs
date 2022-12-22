using System.ComponentModel.DataAnnotations;

namespace InnoGotchiAPI.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "Необходимо указать вашу")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Длинна имени должна составлять от 2 до 10 символов")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Необходимо указать вашу  фамилию")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Длинна имени должна составлять от 2 до 10 символов")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Необходимо указать вашу электронную почту")]
        [EmailAddress(ErrorMessage = "Не является адресом электронной почты")]
        public string Email { get; set; }
        public string AvatarImg { get; set; } = "Default";

        [Required(ErrorMessage = "Необходимо указать ваш пароль")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Длинна пароля должна составлять от 5 до 10 символов")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Необходимо указать ваш пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают, препроверьте и попробуйте их ввести еще раз")]
        public string? PasswordConfirm { get; set; }
    }
}
