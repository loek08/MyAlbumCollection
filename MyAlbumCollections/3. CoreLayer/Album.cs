using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._CoreLayer
{
    public class Album
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public string Lable { get; private set; }
        public string TrackList { get; private set; }
        public string Information { get; private set; }
        public int ArtistId { get; private set; }




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
