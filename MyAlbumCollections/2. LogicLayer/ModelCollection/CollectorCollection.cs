using _2._LogicLayer.Interfaces;
using _2._LogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._LogicLayer.ModelCollection
{
    public class CollectorCollection
    {
        private ICollectionRepository _repository;
        private IAlbumRepository _albumRepository;

        public CollectorCollection(ICollectionRepository repository, IAlbumRepository albumRepository)
        {
            _repository = repository;
            _albumRepository = albumRepository;
        }

        public void AddAlbumToCollectorsCollection(int collectorId, int albumId)
        {
            Album? album = _albumRepository.GetSpecificAlbum(albumId); 
            Collector? collector = _repository.GetSpecificCollerctor(collectorId);


            collector.AddAlbumToCollectorsCollection(album);

            _repository.AddAlbumToCollectorsCollection(collectorId, albumId);
        }

        public void ClearCollectorsCollection()
        {

        }
    }
}
