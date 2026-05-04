
using _4._DataLayer.FakeData;


namespace MyAlbumCollectionsUnitTests
{
    
    public class GetSpecificCollectorTest
    {
        [Fact]
        public void GetSpecificFirstNameCollectorFromTheDataBase() 
        {
            // arrange
            int userId = 2;
            var collectorserver = new FakeCollectorsRepo();

            // act
            var results = collectorserver.GetSpecificCollector(userId);
            //assert
            Assert.Equal(results.FirstName, "Jane");
        }
        [Fact]
        public void GetSpecificIdCollectorFromTheDataBase()
        {
            // arrange
            int userId = 2;
            var collectorserver = new FakeCollectorsRepo();

            // act
            var results = collectorserver.GetSpecificCollector(userId);
            //assert
            Assert.Equal(results.Id, 2);
        }
        [Fact]
        public void GetSpecificSurnameCollectorFromTheDataBase()
        {
            // arrange
            int userId = 2;
            var collectorserver = new FakeCollectorsRepo();

            // act
            var results = collectorserver.GetSpecificCollector(userId);
            //assert
            Assert.Equal(results.Surname, "Smith");
        }
        [Fact]
        public void GetSpecificFirstNameFromID1FromTheDataBase()
        {
            // arrange
            int userId = 1;
            var collectorserver =  new FakeCollectorsRepo();

            // act
            var results = collectorserver.GetSpecificCollector(userId);
            //assert
            Assert.Equal(results.FirstName, "John");
        }
      

    }
}
