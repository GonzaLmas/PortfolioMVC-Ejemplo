using Portfolio.Models;

namespace Portfolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoViewModel> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectoViewModel> ObtenerProyectos()
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

    }
}
