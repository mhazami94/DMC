using DTO;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Services.Mail
{
    public class MailSender
    {
        private string _webmail = "smtp.yandex.com.tr";
        private string _sender = "customer@dmcfx.com";
        private string _password = "cust2020!!..";
        private SmtpClient client;
        public MailSender()
        {
            client = new SmtpClient(_webmail);
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;

            System.Net.NetworkCredential credentials =
                new System.Net.NetworkCredential(_sender, _password);
            client.EnableSsl = true;
            client.Credentials = credentials;
        }
        public bool SendFormToSupport(Customer customer, string email, string subject)
        {
            MailMessage message = new MailMessage(_sender, email);
            message.IsBodyHtml = true;
            message.Subject = subject;
            var body = new StringBuilder();
            body.AppendLine("<table><tr>");
            body.AppendLine("<td style = 'padding-left:15px;padding-right:15px'> Sender Name :</td>");
            body.AppendLine($"<td style = 'padding-left:15px;padding-right:15px'>{customer.FirstName} {customer.LastName}</td></tr>");
            body.AppendLine("<tr><td style = 'padding-left:15px;padding-right:15px'> Email :</td>");
            body.AppendLine($"<td style = 'padding-left:15px;padding-right:15px'>{customer.Email}</td></tr>");
            body.AppendLine("<tr><td style = 'padding-left:15px;padding-right:15px'> Telefon :</td>");
            body.AppendLine($"<td style = 'padding-left:15px;padding-right:15px'>{customer.Password}</td></tr>");
            body.AppendLine("<tr><td style = 'padding-left:15px;padding-right:15px'> Telefon 2:</td>");
            body.AppendLine($"<td style = 'padding-left:15px;padding-right:15px'>{customer.RepeatPassword}</td></tr>");
            body.AppendLine("<tr><td style = 'padding-left:15px;padding-right:15px'> Country :</td>");
            body.AppendLine($"<td style = 'padding-left:15px;padding-right:15px'>{customer.Country}</td></tr></table>");
            message.Body = body.ToString();
            client.Send(message);
            return true;

        }

        public bool SendForForgotPassword(string mail, string email, string subject)
        {
            MailMessage message = new MailMessage(_sender, email);
            message.IsBodyHtml = true;
            message.Subject = subject;
            var body = new StringBuilder();
            body.AppendLine("<table><tr>");
            body.AppendLine("<td style = 'padding-left:15px;padding-right:15px'> Email :</td>");
            body.AppendLine($"<td style = 'padding-left:15px;padding-right:15px'>{mail}</td></tr></table>");   
       
            message.Body = body.ToString();
            client.Send(message);
            return true;

        }

        public bool SendFormToNewsletter(Newsletter newsletter, string email, string subject)
        {
            MailMessage message = new MailMessage(_sender, email);
            message.IsBodyHtml = true;
            message.Subject = subject;
            var body = new StringBuilder();
            body.AppendLine("<table>");      
            body.AppendLine("<tr><td style = 'padding-left:15px;padding-right:15px'> Email :</td>");
            body.AppendLine($"<td style = 'padding-left:15px;padding-right:15px'>{newsletter.Email}</td></tr></table>");
            message.Body = body.ToString();
            client.Send(message);
            return true;

        }
    }
}
