using _2._LogicLayer;
using _3._CoreLayer;
using Microsoft.AspNetCore.Mvc;
using MyAlbumCollections.Models;

namespace MyAlbumCollections.Controllers
{
    public class AlbumController : Controller
    {
        private readonly AlbumServer _albumServer;
        public List<Album> Albums { get; set; }
        public AlbumController(AlbumServer albumServer)
        {
            _albumServer = albumServer;
        }
        public IActionResult Index()
        {
            var albums = _albumServer.GetAlbums();
            var viewModel = new AlbumIndexViewModel { Albums = albums };
            return View(viewModel);
        }
    }
}
