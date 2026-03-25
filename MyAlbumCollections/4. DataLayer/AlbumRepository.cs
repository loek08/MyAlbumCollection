using _3._CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace _4._DataLayer
{
    public class AlbumRepository
    {
        private readonly string _connectionString = "Server=(localdb)\\MyLocalDB;Database=MyAlbumCollection;Trusted_Connection=True;";

        public List<Album> GetAlbums()
        {
            List<Album> albums = new List<Album>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM Album";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int id = reader.GetInt32(reader.GetOrdinal("Id"));
                            string title = reader.GetString(reader.GetOrdinal("Name"));
                            string genre = reader.GetString(reader.GetOrdinal("Genre"));
                            string lable = reader.GetString(reader.GetOrdinal("Lable"));
                            string tracklist = reader.GetString(reader.GetOrdinal("Tracklist"));
                            string information = reader.GetString(reader.GetOrdinal("Information"));
                            int artist = reader.GetInt32(reader.GetOrdinal("ArtistId"));

                            albums.Add(new Album(id, title, genre, lable, tracklist, information, artist));

                        }
                    }
                }

            }
            return albums;
        }
    }
}
