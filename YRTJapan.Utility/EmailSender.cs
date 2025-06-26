using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YRTJapan.Core.Entities;
using MimeKit;
using Microsoft.Extensions.Logging;
using System.Diagnostics.Eventing.Reader;
using System.Net.Mail;
using System.Net;

namespace YRTJapan.Utility
{
    public class EmailSender : IEmailSender
    {
        private readonly SMTP _smtp;
        private readonly ILogger<EmailSender> _logger;
        public EmailSender(SMTP smtp, ILogger<EmailSender> logger)
        {
            _smtp = smtp;
            _logger = logger;
        }

        public Task SendEmailMimeAsync(string email, string subject, string htmlMessage)
        {
            // Create the message object to be sent
            var message = new EmailMessage(new string[] { email! }, subject, htmlMessage);

            // Run the email sending process in a background task
            Task.Run(() =>
            {
                var emailMessage = CreateEmailMessage(message, subject);
                return Send(emailMessage);
            })
            .ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    _logger.LogError(task.Exception.Message);
                }
            });

            // Immediately return a completed task, assuming success
            return Task.CompletedTask;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            Task.Run(() =>
            {
                return SendMailInfo(email, subject, htmlMessage);
            })
            .ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    _logger.LogError(task.Exception.Message);
                }
            });
            return Task.CompletedTask;
        }

        private MimeMessage CreateEmailMessage(EmailMessage message, string subject)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(subject, _smtp.MAIL_FROM));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = message.Content };
            return emailMessage;
        }

        private bool SendMailInfo(string toEmail, string subject, string htmlMessage)
        {
            SmtpClient smtpClient = new SmtpClient(_smtp.MAIL_SMTP_SERVER, _smtp.MAIL_PORT);
            smtpClient.Credentials = new NetworkCredential(_smtp.MAIL_USERNAME, _smtp.MAIL_PASSWORD);
            smtpClient.EnableSsl = true;
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(_smtp.MAIL_FROM);
            mailMessage.To.Add(toEmail); // Replace with the recipient's email address
            mailMessage.Subject = subject;
            mailMessage.Body = htmlMessage;
            mailMessage.IsBodyHtml = true;

            try
            {
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private bool Send(MimeMessage mailMessage)
        {
            using var client = new MailKit.Net.Smtp.SmtpClient();
            try
            {
                client.Connect(_smtp.MAIL_SMTP_SERVER, _smtp.MAIL_PORT, true);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(_smtp.MAIL_USERNAME, _smtp.MAIL_PASSWORD);
                client.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }
    }
}
