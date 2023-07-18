using Exemplo.Business.Models;

namespace Exemplo.Business.Interfaces.Emails
{
    public interface IEmailService
    {
        Task SendEmailAsync(EmailMessage mensagem);
    }
}
