﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace menu.Utils
{
    public class GMailer
    {
        public static string GmailUsername {  get; set; }
        public static string GmailPassword { get; set; }
        public static string GmailHost  { get; set; }
        public static int GmailPort { get; set; }
        public static bool GmailSSL { get; set; }

        public string ToEmail {  get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }

        static GMailer()
        {
            GmailHost = "smtp.gmail.com";
            GmailPort = 25;
            GmailSSL = true;

        }

        public void Send ()
        {
            SmtpClient smtp= new SmtpClient();
            smtp.Host = GmailHost;
            smtp.Port = GmailPort;
            smtp.EnableSsl = GmailSSL;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(GmailUsername, GmailPassword);

            try
            {
                using(var message = new MailMessage(GmailUsername, ToEmail))
                {
                    message.Subject = Subject;
                    message.Body = Body;
                    message.IsBodyHtml = IsHtml;
                    smtp.Send(message);
                }

            }
            catch (Exception ex)
            {
                /// to do : stockage dans une table pour un envoi anterieur
            }
        }

        public static void senMail(string destinataire, string subject, string body)
        {
            try
            {
                GMailer.GmailUsername = "aliou.18.ndour@gmail.com";//System.Configuration.ConfigurationManager.AppSettings["Email"];
                GMailer.GmailPassword = "lzgt jtok qwld jfsx";//System.Configuration.ConfigurationManager.AppSettings["PasswordEmail"];

                GMailer mailer = new GMailer();
                mailer.ToEmail = destinataire;
                mailer.Subject = subject;
                mailer.Body = body;
                mailer.IsHtml = true;
                mailer.Send();
            }
            catch (Exception ex)
            {
                Helper.WriteLogSystem(ex.ToString(), "GMailer-senMail");

            }
        }
    }
}
