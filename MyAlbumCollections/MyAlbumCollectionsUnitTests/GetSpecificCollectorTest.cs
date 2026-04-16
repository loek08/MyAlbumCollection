using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4._DataLayer.FakeData;
using System.Reflection.Metadata;
using _3._CoreLayer;
using _2._LogicLayer;

namespace MyAlbumCollectionsUnitTests
{
    
    public class GetSpecificCollectorTest
    {
        [Fact]
        public void GetSpecificFirstNameCollectorFromTheDataBase() 
        {
            // arrange
            int userId = 2;
            var collectorserver = new CollectorServer(new FakeCollectorsRepo());

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
            var collectorserver = new CollectorServer(new FakeCollectorsRepo());

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
            var collectorserver = new CollectorServer(new FakeCollectorsRepo());

            // act
            var results = collectorserver.GetSpecificCollector(userId);
            //assert
            Assert.Equal(results.Surname, "Smith");
        }

    }
}
