using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._LogicLayer.Models
{
    public class Collector
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAdress { get; set; }
        public List<Album> Albums { get; set; } = new List<Album>();

        public Collector (int id, string firstName, string surname, string username, string password, string emailAdress)
        {
            Id = id;
            FirstName = firstName;
            Surname = surname;
            Username = username;
            Password = password;
            EmailAdress = emailAdress;
        }

        public void AddAlbumToCollectorsCollection(Album album)
        {
           Albums.Add(album);
        }
    }
}
