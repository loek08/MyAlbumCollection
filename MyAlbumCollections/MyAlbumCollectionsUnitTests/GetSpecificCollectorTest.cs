using _2._LogicLayer.Models;
using _2._LogicLayer;
using _4._DataLayer.FakeData;


namespace MyAlbumCollectionsUnitTests
{

    public class GetSpecificCollectorTest
    {
        [Fact]
        public void GetSpecificFirstNameCollectorFromTheDataBase()
        {
            // arrange
            var repository = new FakeCollectorsRepo();
            var collectorserver = new CollectorService(repository);

            // act
            var results = collectorserver.GetSpecificCollector(2);
            
            // assert
            Assert.NotNull(results);
            Assert.IsType<Collector>(results);
        }


    }
}
