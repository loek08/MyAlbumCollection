using _2._LogicLayer.Interfaces;
using _2._LogicLayer.Models;

namespace _2._LogicLayer
{
    public class AlbumService
    {
        private IAlbumRepository _repository;
        public AlbumService(IAlbumRepository repository)
        {
            _repository = repository;
        }

        public List<Album> GetAlbums()
        {
            var data = _repository.GetAlbums();

            return data;
        }


        public List<Album> GetSpecificAlbum(int id)
       {
            return _repository.GetSpecificAlbum(id);

        }
       

    }
}
