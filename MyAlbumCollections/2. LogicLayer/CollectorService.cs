using _2._LogicLayer.Interfaces;
using _2._LogicLayer.Models;

namespace _2._LogicLayer
{
    public class CollectorService
    {
        private ICollectionRepository _repository;

        public CollectorService(ICollectionRepository repository)
            {
                _repository = repository;
            }

        public void AddAlbumToCollectorsCollection(int collector, int album)
        {
            _repository.AddAlbumToCollectorsCollection(collector, album);
        }

        public List<Album> GetCollectorsCollection(int collector)
        {
            var data = _repository.GetCollectorsCollection(collector);

            return data.Select(a => new Album(
                a.Id,
                a.Title,
                a.Genre,
                a.Lable,
                a.TrackList,
                a.Information,
                a.ArtistId
            )).ToList();
        }

        public Collector? GetSpecificCollector(int id)
        {
            return _repository.GetSpecificCollerctor(id);
        }
    }
}

