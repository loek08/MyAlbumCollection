using _3._CoreLayer;
using Microsoft.Data.SqlClient;

namespace _4._DataLayer
{
    public class CollectionRepository
    {
        private readonly string connectionString = "Server=(localdb)\\MyLocalDB;Database=MyAlbumCollection;Trusted_Connection=True;";

        public void AddAlbumToCollectorsCollection(Collector collector, Album album)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Collector_Album (CollectorId, AlbumId) VALUES (@CollectorId, @AlbumId)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CollectorId", collector.Id);
                    cmd.Parameters.AddWithValue("@AlbumId", album.Id);
                }
            }
        }

        public List<Collector> GetSpecificCollerctor(int CollectorId)
        {
            List<Collector> specificCollector = new List<Collector>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Collector WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", CollectorId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int collectorId = reader.GetInt32(reader.GetOrdinal("Id"));
                            string firstName = reader.GetString(reader.GetOrdinal("Firstname"));
                            string surName = reader.GetString(reader.GetOrdinal("Surname"));
                            string userName = reader.GetString(reader.GetOrdinal("Username"));
                            string password = reader.GetString(reader.GetOrdinal("Password"));
                            string emailAdress = reader.GetString(reader.GetOrdinal("EmailAdress"));
                            specificCollector.Add(new Collector(collectorId, firstName, surName, userName, password, emailAdress));
                        }
                    }
                }
            }
            return specificCollector;  
        }
    }
}
