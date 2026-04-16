using _2._LogicLayer;
using _3._CoreLayer;
using Microsoft.AspNetCore.Mvc;
using MyAlbumCollections.Models;

namespace MyAlbumCollections.Controllers
{
    public class AlbumController : Controller
    {
        private readonly AlbumServer _albumServer;
        //public List<Album> Albums { get; set; }
        //public List<Collector> Collectors { get; set; }
        //public List<Album> AlbumList { get; set; }
        //public List<Collector> CollectorList { get; set; }
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
        public IActionResult AddAlbumToCollection(int albumId)
        {

            int collectorId = 1;
            

            return RedirectToAction("Index", "Collection", new {id = collectorId, idAlbum = albumId} );


        }
        public IActionResult SpecificAlbum(int albumId)
        {
            var specificAlbum = _albumServer.GetSpecificAlbum(albumId);
            var viewModel = new AlbumIndexViewModel { Albums = specificAlbum };
            return View(viewModel);
        }
    }
}
