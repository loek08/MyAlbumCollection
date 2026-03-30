using _3._CoreLayer;
using Microsoft.AspNetCore.Mvc;

namespace MyAlbumCollections.Controllers
{
    public class CollectionController : Controller
    {
        public List<Album> PesificAlbums { get; set; }
        public IActionResult Index()
        {


            return View();
        }


    }
}
