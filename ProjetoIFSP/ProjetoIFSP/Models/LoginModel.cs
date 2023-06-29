using System.ComponentModel.DataAnnotations;

namespace ProjetoIFSP.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite um e-mail válido")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite uma senha válida")]
        public string Senha { get; set; }
    }
}
