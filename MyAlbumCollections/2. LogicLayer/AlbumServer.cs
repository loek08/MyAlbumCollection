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
        public AlbumServer()
        {
            _repository = new AlbumRepository();
        }

        public List<Album> GetAlbums()
        {
            return _repository.GetAlbums();
        }
    }
}
