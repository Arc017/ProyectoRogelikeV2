using Microsoft.AspNetCore.Mvc;
using ProyectoRogelike.Modelo.Personajes;
using ProyectoRogelikeV2.Data;
using ProyectoRogelikeV2.Models;
using System.Diagnostics;

namespace ProyectoRogelikeV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProyectoRogelikeDbContext db;
        List<Personaje> personajeList;

        public HomeController(ILogger<HomeController> logger, ProyectoRogelikeDbContext PRogelikeContext)
        {
            _logger = logger;
            db = PRogelikeContext;
        }

        public IActionResult Index()
        {
            personajeList = db.Personaje.ToList();
            return View(personajeList);
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