using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._CoreLayer
{
    public class Collector
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAdress { get; set; }
        public List<Album> Albums { get; set; }

        public Collector (string firstName, string surname, string username, string password, string emailAdress)
        {
            FirstName = firstName;
            Surname = surname;
            Username = username;
            Password = password;
            EmailAdress = emailAdress;
        }
    }
}
