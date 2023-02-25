using System.Data.SqlClient;

namespace Single_Responsibility_Principle
{
    public class UserRepository
    {
        public void RegisterUser()
        {
            using var connection = new SqlConnection("connectionString");

            var command = new SqlCommand("INSERT INTO [...]"); // add user to db
            command.ExecuteNonQuery();
        }
    }
}
