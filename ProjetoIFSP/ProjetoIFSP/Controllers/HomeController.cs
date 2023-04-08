using Microsoft.AspNetCore.Mvc;
using ProjetoIFSP.Models;
using System.Diagnostics;

namespace ProjetoIFSP.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();

            home.Nome = "Maycon de Lima César";
            home.Email = "lima.maycon@aluno.ifsp.edu.br";

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}