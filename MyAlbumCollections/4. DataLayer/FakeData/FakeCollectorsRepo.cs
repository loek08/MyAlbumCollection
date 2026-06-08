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
        public void AddAlbumToCollectorsCollection(int collector, int album)
        {
            return;
        }
        public List<Album> GetCollectorsCollection(int collector)
        {
            return new List<Album>();
        }

        public Collector? GetSpecificCollerctor(int CollectorId)
        {

            return new Collector(2,"lara","jansen","jara","121212","gmail@gmail.com");
        }
    }
}
