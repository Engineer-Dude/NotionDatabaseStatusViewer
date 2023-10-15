using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace NotionDatabaseStatusViewer.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly ILogger _logger;

        public AuthMessageSenderOptions Options { get; }
        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor, ILogger<EmailSender> logger)
        {
            Options = optionsAccessor.Value;
            _logger = logger;
        }
        public async Task SendEmailAsync(string toEmail, string subject, string message)
        {
            if (string.IsNullOrEmpty(Options.SendGridKey))
            {
                throw new Exception("Null SendGridKey");
            }

            await Execute(Options.SendGridKey, subject, message, toEmail);
        }

        public async Task Execute(string apiKey, string subject, string message, string toEmail)
        {
            SendGrid.Response? response = null;

            var client = new SendGridClient(apiKey);

            var msg = new SendGridMessage
            {
                From = new EmailAddress("<sender email address>", "<optional sender name>"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };

            msg.AddTo(new EmailAddress(toEmail));

            // Disable click tracking
            // See See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            msg.SetClickTracking(enable: false, enableText: false);

            response = await client.SendEmailAsync(msg);

            _logger.LogInformation(response.IsSuccessStatusCode
                ? $"Email to {toEmail} queued successfully"
                : $"Email to {toEmail} failed");
        }
    }
}

