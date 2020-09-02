using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "邮箱")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "地址列表")]
        public AddressViewModel Address { get; set; }

        public bool IsValid { get; set; }
    }
}