
using Microsoft.Data.SqlClient;
using _2._LogicLayer.Models;
using _2._LogicLayer.Interfaces;



namespace _4._DataLayer
{
    public class AlbumRepository : IAlbumRepository
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
                            string trackList = reader.GetString(reader.GetOrdinal("Tracklist"));
                            string information = reader.GetString(reader.GetOrdinal("Information"));
                            int artistId = reader.GetInt32(reader.GetOrdinal("ArtistId"));

                            albums.Add(new Album (id, title, genre, lable, trackList, information, artistId));

                        }
                    }
                }

            }
            return albums;
        }
        public Album? GetSpecificAlbum(int id)
        {
            Album? specificAlbum = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Album WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int albumId = reader.GetInt32(reader.GetOrdinal("Id"));
                            string title = reader.GetString(reader.GetOrdinal("Name"));
                            string genre = reader.GetString(reader.GetOrdinal("Genre"));
                            string lable = reader.GetString(reader.GetOrdinal("Lable"));
                            string tracklist = reader.GetString(reader.GetOrdinal("Tracklist"));
                            string information = reader.GetString(reader.GetOrdinal("Information"));
                            int artist = reader.GetInt32(reader.GetOrdinal("ArtistId"));
                            specificAlbum = new Album(albumId, title, genre, lable, tracklist, information, artist);
                        }
                    }
                }
            }
            return specificAlbum;
        }
    }
}

        
