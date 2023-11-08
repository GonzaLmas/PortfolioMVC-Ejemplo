using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<ProyectoViewModel> ObtenerProyectos()
        {
            return new List<ProyectoViewModel> { new ProyectoViewModel
            {
                Titulo = "Amazon",
                Descripcion="E-Commerce realizado en ASP .NET Core",
                link="https://amazon.com",
                ImagenURL= "/Imagenes/amazon.png"
            },
            new ProyectoViewModel
            {
                Titulo = "New York Times",
                Descripcion="Página de noticias en React",
                link="https://nytimes.com",
                ImagenURL= "/Imagenes/nyt.png"
            },
            new ProyectoViewModel
            {
                Titulo = "Reddit",
                Descripcion="Red social para compartir en comunidades",
                link="https://reddit.com",
                ImagenURL="/Imagenes/reddit.png"
            },
            new ProyectoViewModel
            {
                Titulo = "Steam",
                Descripcion="Tienda online para comprar videojuegos",
                link="https://store.steampowered.com",
                ImagenURL="/Imagenes/steam.png"
            }
            };
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