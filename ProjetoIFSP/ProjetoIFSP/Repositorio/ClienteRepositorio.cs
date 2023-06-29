using ProjetoIFSP.Data;
using ProjetoIFSP.Models;

namespace ProjetoIFSP.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        
        private readonly BancoContext _bancoContext;
        public ClienteRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext; //instanciar o banco
        }

        public ClienteModel ListarPorId(int id)
        {
            return _bancoContext.Clientes.FirstOrDefault(x => x.Id == id);
        }

        public List<ClienteModel> GetAll()
        {
            return _bancoContext.Clientes.ToList();
        }

        public ClienteModel Adicionar(ClienteModel cliente)
        {
            cliente.DataCadastro = DateTime.Now;
            // gravar no banco de dados
            _bancoContext.Clientes.Add(cliente);
            //comitar
            _bancoContext.SaveChanges();
            return cliente;
        }

        public ClienteModel Atualizar(ClienteModel cliente)
        {
            ClienteModel clienteDB = ListarPorId(cliente.Id);

            if (clienteDB == null) throw new Exception("Houve um erro na atualização do cliente!");

            clienteDB.Nome = cliente.Nome;
            clienteDB.Cpf = cliente.Cpf;
            clienteDB.Telefone = cliente.Telefone;
            clienteDB.Email = cliente.Email;
            clienteDB.DataAltualizacao = DateTime.Now;

            _bancoContext.Clientes.Update(clienteDB);
            _bancoContext.SaveChanges();

            return clienteDB;
        }

        public bool Apagar(int id)
        {
            ClienteModel clienteDB = ListarPorId(id);

            if (clienteDB == null) throw new Exception("Houve um erro na deleção do cliente!");

            _bancoContext.Clientes.Remove(clienteDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
