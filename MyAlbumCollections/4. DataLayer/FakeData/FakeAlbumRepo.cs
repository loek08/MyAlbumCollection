using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2._LogicLayer.Interfaces;
using _2._LogicLayer.Models;

namespace _4._DataLayer.FakeData
{
    public class FakeAlbumRepo : IAlbumRepository
    {
        private Album _album = new Album(1, "test", "Rock", "Test Label", "Track 1, Track 2, Track 3", "This is a test album.", 1);

        public List<Album> GetAlbums()
        {
            throw new NotImplementedException();
        }

        public Album? GetSpecificAlbum(int id)
        {

            return _album;
        }
    }
}
