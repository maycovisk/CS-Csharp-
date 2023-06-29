using ProjetoIFSP.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjetoIFSP.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do Usuário")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Login do usuário")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o Email do usuário")]
        [EmailAddress(ErrorMessage = "O email informado não é valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o perfil do Usuário")]
        public PerfilEnum? Perfil { get; set; }
        [Required(ErrorMessage = "Digite a senha do Usuário")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAltualizacao { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }
    }
}
