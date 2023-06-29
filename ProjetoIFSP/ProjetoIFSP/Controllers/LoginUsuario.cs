using Microsoft.AspNetCore.Mvc;
using ProjetoIFSP.Models;

namespace ProjetoIFSP.Controllers
{
    public class LoginUsuario : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginUser()
        {
            return View();
        }

        public IActionResult LoginDriver()
        {
            return View();
        }

        //private readonly IUsuarioRepositorio _usuarioRepositorio;
        //public LoginController(IUsuarioRepositorio usuarioRepositorio)
        //{
        //    _usuarioRepositorio = usuarioRepositorio;
        //}

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (loginModel.Login == "admin@admin" && loginModel.Senha == "admin")
                    {
                        return RedirectToAction("Index", "Home");
                    }

                    TempData["MensagemErro"] = $"Usuário ou senha inválido(a). Tente novamente...";

                }

                return View("LoginUser");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível efetuar o login, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("LoginUser");
            }
        }



    }
}
