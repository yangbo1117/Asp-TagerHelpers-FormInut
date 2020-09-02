
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class AddressViewModel
    {
        [Display(Name = "地址名称")]
        public string AddressName { get; set; }

        [Display(Name = "地址编码")]
        public string AddressCode { get; set; }

    }
}