using System.Data.SqlClient;
using System.Net.Mail;

namespace Single_Responsibility_Principle
{
    public class AddUserService
    {
        public void AddUser()
        {
            using var connection = new SqlConnection("connectionString");

            var command = new SqlCommand("INSERT INTO [...]"); // add user to db
            command.ExecuteNonQuery();

            // sending email
            var smtpClient = new SmtpClient();
            smtpClient.Send(new MailMessage());
        }
    }
}
