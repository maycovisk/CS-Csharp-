using ProjetoIFSP.Models;

namespace ProjetoIFSP.Repositorio
{
    public interface IClienteRepositorio
    {
        ClienteModel ListarPorId(int id);
        List<ClienteModel> GetAll();
        ClienteModel Adicionar(ClienteModel cliente);

        ClienteModel Atualizar(ClienteModel cliente);

        bool Apagar(int id);
    }
}