using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3._CoreLayer;
using _4._DataLayer;

namespace _2._LogicLayer
{
    public class AlbumServer
    {
        private AlbumRepository _repository;
        public AlbumServer(AlbumRepository repository)
        {
            _repository = repository;
        }

        public List<Album> GetAlbums()
        {
            var data = _repository.GetAlbums();

            return data.Select(x => new Album(
                x.Id,
                x.Title,
                x.Genre,
                x.Lable,
                x.TrackList,
                x.Information,
                x.ArtistId
            )).ToList();
        }


        public List<Album> GetSpecificAlbum(int id)
       { 
            //return _repository.GetSpecificAlbum(id);
            return new List<Album>();
       }
       

    }
}
