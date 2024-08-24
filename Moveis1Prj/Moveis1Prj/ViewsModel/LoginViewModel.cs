using System.ComponentModel.DataAnnotations;

namespace Moveis1Prj.ViewsModel
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="E-mail")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set;}
    }
}
