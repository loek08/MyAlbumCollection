using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2._LogicLayer.Models;
using _2._LogicLayer.Interfaces;

namespace _4._DataLayer.FakeData
{
    public class FakeCollectorsRepo : ICollectionRepository
    {
        private Collector _collector =
            new Collector(1, "lara", "jansen", "jara", "121212", "gmail@gmail.com");
        private List<Album> _albums = new();

        public void AddAlbumToCollectorsCollection(int collectorId, int albumId)
        {
            // Store information that this relationship exists
            _albums.Add(new Album(albumId, "...", "...", "...", "...", "...", 1));
        }

        public List<Album> GetCollectorsCollection(int collectorId)
        {
            return _albums;
        }

        public Collector? GetSpecificCollerctor(int CollectorId)
        {

            return _collector;
        }
    }
}
