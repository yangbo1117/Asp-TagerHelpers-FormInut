using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public enum CountryEnum
    {
        [Display(Name = "墨西哥")]
        Mexico,
        [Display(Name = "美国")]
        USA,
        Canada,
        [Display(Name = "法国")]
        France,
        Germany,
        Spain
    } 
}