using ProjetoIFSP.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjetoIFSP.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o CPF do cliente")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Digite o Telefone do cliente")]
        [Phone(ErrorMessage = "O telefone informado não é valido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Digite o Email do cliente")]
        [EmailAddress(ErrorMessage = "O email informado não é valido")]
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAltualizacao { get; set; }
    }
}
