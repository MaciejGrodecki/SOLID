using System.Data.SqlClient;
using System.Net.Mail;

namespace Single_Responsibility_Principle
{
    public class AddUserService
    {
        private readonly UserRepository _userRepository = new();
        private readonly SendEmailService _sendEmailService = new();

        public AddUserService(UserRepository userRepository, SendEmailService sendEmailService)
        {
            _userRepository = userRepository;
            _sendEmailService = sendEmailService;
        }

        public void AddUser()
        {
            _userRepository.RegisterUser();
            _sendEmailService.SendRegistrationEmail();
        }
    }
}
