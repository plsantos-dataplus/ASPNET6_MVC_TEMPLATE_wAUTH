using Microsoft.AspNetCore.Identity.UI.Services;

namespace ASPNET6_MVC_TEMPLATE_wAUTH.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.CompletedTask;
        }
    }
}
