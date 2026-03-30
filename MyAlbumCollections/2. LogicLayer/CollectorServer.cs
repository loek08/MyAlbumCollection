using _3._CoreLayer;
using _4._DataLayer;

namespace _2._LogicLayer
{
    public class CollectorServer
    {
        private CollectionRepository _repository;

            public CollectorServer(CollectionRepository repository)
            {
                _repository = repository;
            }
    
            public void AddAlbumToCollectorsCollection(Collector collector, Album album)
            {
                _repository.AddAlbumToCollectorsCollection(collector, album);
            }
    }
}
