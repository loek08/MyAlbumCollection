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
    }
}
