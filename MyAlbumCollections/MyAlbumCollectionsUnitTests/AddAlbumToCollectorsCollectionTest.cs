using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2._LogicLayer.Interfaces;
using _2._LogicLayer.ModelCollection;
using _2._LogicLayer.Models;
using _4._DataLayer.FakeData;
using FluentAssertions;

namespace MyAlbumCollectionsUnitTests
{
    public class AddAlbumToCollectorsCollectionTest
    {
        [Fact]
        public void NeedsToReturnAnAlbumWithId1()
        {
            // arrange
            FakeCollectorsRepo collectorsRepository = new FakeCollectorsRepo();
            FakeAlbumRepo albumRepository = new FakeAlbumRepo();
            CollectorCollection collectorCollection = new CollectorCollection(collectorsRepository, albumRepository);
            Album album = new Album(1, "test", "Rock", "Test Label", "Track 1, Track 2, Track 3", "This is a test album.", 1);
            // act

            collectorCollection.AddAlbumToCollectorsCollection(1,1);

            // Assert
            var collector = collectorsRepository.GetSpecificCollerctor(1);


            collector.Albums[0].Should().BeEquivalentTo(album);


        }

        [Fact]
        public void NeedsToReturnACollectorWithId1()
        {
            // arrange
            var repository = new FakeCollectorsRepo();
            var albumRepository = new FakeAlbumRepo();
            var collectorCollection = new CollectorCollection(repository, albumRepository);
            // act
            var result = repository.GetSpecificCollerctor(1);
            // assert
            Assert.Equal(result.Id, 1);

        }
    }
}
