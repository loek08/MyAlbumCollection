using _3._CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using _4._DataLayer.DataModel;

namespace _4._DataLayer
{
    public class AlbumRepository
    {
        private readonly string _connectionString = "Server=(localdb)\\MyLocalDB;Database=MyAlbumCollection;Trusted_Connection=True;";

        public List<AlbumData> GetAlbums()
        {
            List<AlbumData> albums = new List<AlbumData>();
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
                            albums.Add(new AlbumData {

                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Title = reader.GetString(reader.GetOrdinal("Name")),
                            Genre = reader.GetString(reader.GetOrdinal("Genre")),
                            Lable = reader.GetString(reader.GetOrdinal("Lable")),
                            TrackList = reader.GetString(reader.GetOrdinal("Tracklist")),
                            Information = reader.GetString(reader.GetOrdinal("Information")),
                            ArtistId = reader.GetInt32(reader.GetOrdinal("ArtistId"))

                            });

                        }
                    }
                }

            }
            return albums;
        }
        
        public List<AlbumData> GetSpecificAlbum(int id)
        {
            List<AlbumData> specificAlbum = new List<AlbumData>();
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
                            specificAlbum.Add(new AlbumData {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Title = reader.GetString(reader.GetOrdinal("Name")),
                            Genre = reader.GetString(reader.GetOrdinal("Genre")),
                            Lable = reader.GetString(reader.GetOrdinal("Lable")),
                            TrackList = reader.GetString(reader.GetOrdinal("Tracklist")),
                            Information = reader.GetString(reader.GetOrdinal("Information")),
                            ArtistId = reader.GetInt32(reader.GetOrdinal("ArtistId"))
                          });
                 
                        }
                    }
                }
            }
            return specificAlbum;
        }
    }
}

        
