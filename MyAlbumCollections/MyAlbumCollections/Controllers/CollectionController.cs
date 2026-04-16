
using Microsoft.AspNetCore.Mvc;
using MyAlbumCollections.Models;
using _2._LogicLayer;

namespace MyAlbumCollections.Controllers
{
    public class CollectionController : Controller
    {
        private readonly CollectorServer _collectorServer;
        private readonly AlbumServer _albumServer;
        public CollectionController(CollectorServer collectorServer, AlbumServer albumServer)
        {
            _collectorServer = collectorServer;
            _albumServer = albumServer;
        }

        public IActionResult Index(int id, int idAlbum)
        {
            _collectorServer.AddAlbumToCollectorsCollection(id, idAlbum);
            var list = _collectorServer.GetCollectorsCollection(id);
            var viewModel = new AlbumIndexViewModel { Albums = list };
            return View(viewModel);
        }


    }
}
