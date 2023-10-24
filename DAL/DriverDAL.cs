using Microsoft.Data.SqlClient;
using MyFleetManager.Models;

namespace MyFleetManager.DAL
{
    public class DriverDAL
    {
        string connectionString;

        public IEnumerable<Driver> GetAllDriver()
        {
            List<Driver> drivers = new List<Driver>() ;
            using SqlConnection con = new SqlConnection(connectionString)
        }
    }
}
