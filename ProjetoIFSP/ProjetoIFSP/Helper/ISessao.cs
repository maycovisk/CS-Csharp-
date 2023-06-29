using ProjetoIFSP.Models;

namespace ProjetoIFSP.Helper
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(UsuarioModel usuario);
        void RemoverSessaoUsuario();
        UsuarioModel BuscarSessaoDoUsuarios();
    }
}
