using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4._DataLayer;

namespace _3._CoreLayer
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Lable { get; set; }
        public string TrackList { get; set; }
        public string Information { get; set; }
        public int ArtistId { get; set; }
        public List<Collector> Collectors { get; set; }
        private AlbumRepository _repository;


        public Album(int id, string title, string genre, string lable, string tracklist, string information, int artist)
        {
            Id = id;
            Title = title;
            Genre = genre;
            Lable = lable;
            TrackList = tracklist;
            Information = information;
            ArtistId = artist;
        }

    }
}
