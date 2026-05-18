
using _2._LogicLayer.Models;
using _2._LogicLayer.Interfaces;
using Microsoft.Data.SqlClient;

namespace _4._DataLayer
{
    public class CollectionRepository : ICollectionRepository
    {
        private readonly string connectionString = "Server=(localdb)\\MyLocalDB;Database=MyAlbumCollection;Trusted_Connection=True;";

        public void AddAlbumToCollectorsCollection(int collector, int album)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Album_Collector (CollectorId, AlbumId) VALUES (@CollectorId, @AlbumId)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //cmd.Parameters.AddWithValue("@CollectorId", collector);
                    //cmd.Parameters.AddWithValue("@AlbumId", album);
                    cmd.Parameters.Add(new SqlParameter("@AlbumId",album));
                    cmd.Parameters.Add(new SqlParameter("@CollectorId", collector));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Album> GetCollectorsCollection(int collector)
        {
            List<Album> list = new List<Album>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT a.* FROM Album a INNER JOIN Album_Collector ca ON a.Id = ca.AlbumId WHERE ca.CollectorId = @CollectorId";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CollectorId", collector);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int Id = reader.GetInt32(reader.GetOrdinal("Id"));
                            string title = reader.GetString(reader.GetOrdinal("Name"));
                            string Genre = reader.GetString(reader.GetOrdinal("Genre"));
                            string Lable = reader.GetString(reader.GetOrdinal("Lable"));
                            string TrackList = reader.GetString(reader.GetOrdinal("Tracklist"));
                            string Information = reader.GetString(reader.GetOrdinal("Information"));
                            int ArtistId = reader.GetInt32(reader.GetOrdinal("ArtistId"));
                            list.Add(new Album(Id, title, Genre, Lable, TrackList, Information, ArtistId));
;
                        }
                    }
                }
            }
            return list;
        }

        public Collector? GetSpecificCollerctor(int CollectorId)
        {
            Collector? specificCollector = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                conn.Open();
                string sql = "SELECT * FROM Collector WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", CollectorId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();

                        int collectorId = reader.GetInt32(reader.GetOrdinal("Id"));
                        string firstName = reader.GetString(reader.GetOrdinal("Firstname"));
                        string surName = reader.GetString(reader.GetOrdinal("Surname"));
                        string userName = reader.GetString(reader.GetOrdinal("Username"));
                        string password = reader.GetString(reader.GetOrdinal("Password"));
                        string emailAdress = reader.GetString(reader.GetOrdinal("EmailAdress"));
                        specificCollector = new Collector(collectorId, firstName, surName, userName, password, emailAdress);

                    }
                }
            }
            return specificCollector;  
        }
    }
}
