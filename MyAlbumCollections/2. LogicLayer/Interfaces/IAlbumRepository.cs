using _2._LogicLayer.Models;

namespace _2._LogicLayer.Interfaces
{
    public interface IAlbumRepository
    {
      public List<Album> GetAlbums();

      public Album? GetSpecificAlbum(int id);
    }
}
