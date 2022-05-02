using Address_Book.Models;
using Address_Book.Models.ViewModels;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Address_Book.Services.Interfaces
{
    public interface IABEmailSender : IEmailSender
    {
        string ComposeEmailBody(AppUser sender, EmailData emailData);
        Task SendEmailAsync(AppUser appUser, List<Contact> contacts, EmailData emailData);
    }
}
 