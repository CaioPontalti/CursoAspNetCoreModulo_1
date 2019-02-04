using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntroducaoLogin.Models;
using IntroducaoLogin.Services;

namespace IntroducaoLogin.Controllers
{
    public class HomeController : Controller
    {
        public IPaisesRepositorioMemoria Repositorio { get; set; }

        public HomeController(IPaisesRepositorioMemoria respositorioPaises)
        {
            Repositorio = respositorioPaises;
        }

        public IActionResult Index()
        {
            var paises = Repositorio.ObterPaises();
            return View(paises);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
