using Blueprint.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace Blueprint.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}