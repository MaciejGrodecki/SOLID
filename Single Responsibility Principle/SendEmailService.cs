using System.Net.Mail;

namespace Single_Responsibility_Principle
{
    public class SendEmailService
    {
        public void SendRegistrationEmail()
        {
            var smtpClient = new SmtpClient();
            smtpClient.Send(new MailMessage());
        }
    }
}
