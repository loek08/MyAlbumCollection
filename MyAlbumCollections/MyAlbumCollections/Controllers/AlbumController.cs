using _2._LogicLayer;
using _3._CoreLayer;
using Microsoft.AspNetCore.Mvc;

namespace MyAlbumCollections.Controllers
{
    public class AlbumController : Controller
    {
        private readonly AlbumServer _albumServer;
        public List<Album> Albums { get; set; }
        public AlbumController()
        {
            _albumServer = new AlbumServer();

        }
        public IActionResult Index()
        {
            {
                Albums = _albumServer.GetAlbums();
                return View();
            }
        }
    }
}
