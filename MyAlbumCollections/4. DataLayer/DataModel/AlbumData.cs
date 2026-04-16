using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._DataLayer.DataModel
{
    public class AlbumData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Lable { get; set; }
        public string TrackList { get;  set; }
        public string Information { get;  set; }
        public int ArtistId { get;  set; }
    }
}
