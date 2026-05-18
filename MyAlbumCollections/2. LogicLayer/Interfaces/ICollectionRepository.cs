using _2._LogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._LogicLayer.Interfaces
{
    public interface ICollectionRepository
    {
        public void AddAlbumToCollectorsCollection(int collector, int album);
        public List<Album> GetCollectorsCollection(int collector);
        public Collector? GetSpecificCollerctor(int CollectorId);


    }
}
