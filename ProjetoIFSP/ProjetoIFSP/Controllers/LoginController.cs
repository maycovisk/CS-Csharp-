using Microsoft.AspNetCore.Mvc;
using ProjetoIFSP.Helper;
using ProjetoIFSP.Models;
using ProjetoIFSP.Repositorio;

namespace ProjetoIFSP.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;
        public LoginController(IUsuarioRepositorio usuarioRepositorio, ISessao sessao)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;

        }
        public IActionResult Index()
        {
            //Se estiver logado, redirecionar para a HOME
            if (_sessao.BuscarSessaoDoUsuarios() != null) return RedirectToAction("Index", "Home");
            return View();
        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                UsuarioModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.Login);
                if (ModelState.IsValid)
                {
                    if (usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            _sessao.CriarSessaoDoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }

                        TempData["MensagemErro"] = $"A senha do usuário é invalida, tente novamente";
                    }

                    TempData["MensagemErro"] = $"Usuário ou senha inválido(a). Tente novamente...";

                }

                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível efetuar o login, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }


    }
}
