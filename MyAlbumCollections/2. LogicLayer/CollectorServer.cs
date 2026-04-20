using _3._CoreLayer;
using _4._DataLayer;
using _4._DataLayer.FakeData;

namespace _2._LogicLayer
{
    public class CollectorServer
    {
        private CollectionRepository _repository;
        private FakeCollectorsRepo _fakeCollectorsRepo;

        public CollectorServer(CollectionRepository repository)
            {
                _repository = repository;
            }
    
            public void AddAlbumToCollectorsCollection(int collector, int album)
            {
                _repository.AddAlbumToCollectorsCollection(collector, album);
            }

            public List<Album> GetCollectorsCollection(int collector)
            {
                //return _repository.GetCollectorsCollection(collector);
                return new List<Album>();
            }

            public Collector? GetSpecificCollector(int id) 
            {
                return _fakeCollectorsRepo.GetSpecificCollector(id);
            }
    }
}

