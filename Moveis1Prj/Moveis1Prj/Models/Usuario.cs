using Microsoft.AspNetCore.Identity;

namespace Moveis1Prj.Models
{
    public class Usuario : IdentityUser
    {
        public string Nome { get; set; }
        public string Telefone { get; set;}
    }
}
