using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntroducaoCoreLogin.Models;
using IntroducaoCoreLogin.Services;

namespace IntroducaoCoreLogin.Controllers
{
    public class HomeController : Controller
    {
        public IPaisRepositorio Repositorio { get; }

        public HomeController(IPaisRepositorio repositorio)
        {
            Repositorio = repositorio;
        }

        public IActionResult Index()
        {
            return View(Repositorio.Obter());
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
