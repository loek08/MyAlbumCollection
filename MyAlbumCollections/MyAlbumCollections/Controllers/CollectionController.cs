
using Microsoft.AspNetCore.Mvc;
using MyAlbumCollections.Models;
using _2._LogicLayer;
using _2._LogicLayer.ModelCollection;

namespace MyAlbumCollections.Controllers
{
    public class CollectionController : Controller
    {
        private readonly CollectorService _collectorServer;
        private readonly AlbumService _albumServer;
        private readonly CollectorCollection _collectorCollection;
        public CollectionController(CollectorService collectorServer, AlbumService albumServer, CollectorCollection collectorCollection)
        {
            _collectorServer = collectorServer;
            _albumServer = albumServer;
            _collectorCollection = collectorCollection;
        }

        public IActionResult Index(int id, int idAlbum)
        {
            try { 
            _collectorCollection.AddAlbumToCollectorsCollection(id, idAlbum);
        }
            catch (InvalidOperationException ex)

            {
                // Show the error to the user
                return BadRequest(ex.Message);

            }

            var list = _collectorServer.GetCollectorsCollection(id);
            var viewModel = new AlbumIndexViewModel { Albums = list };
            return View(viewModel);
        }
         

    }
}
