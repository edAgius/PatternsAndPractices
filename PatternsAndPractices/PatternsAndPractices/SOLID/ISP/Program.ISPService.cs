using System;
using System.Collections.Generic;

namespace PatternsAndPractices
{
    partial class Program
    {
        public class ISPService
        {
            public ISPService()
            {
                var emailMessage = new EmailMessage();

                emailMessage.Message = "awd";
                emailMessage.Recipient = new List<string>{"awd"};
                emailMessage.BCCRecipient = new List<string> { "BCCawd" };
                emailMessage.Subject = "sub";

                Console.WriteLine("ISP Email " + emailMessage.BCCRecipient[0]);

                var smsMessage = new SMSMessage();

                smsMessage.Message = "awd";
                smsMessage.Recipient = new List<string> { "awd" };
                smsMessage.Subject = "sub";

                Console.WriteLine("ISP SMS " + smsMessage.Recipient[0]);
            }

            public interface IMessage
            {
                IList<string> Recipient { get; set; }
                //string Subject { get; set; } this is only used for email
                string Message { get; set; }
                bool send();
                //IList<string> BCCRecipient { get; set; } this is only used for email

            }

            public interface ISMSMessage
            {
                //Some other sms info   
            }
            public interface IEmailMessage : IMessage
            {
                string Subject { get; set; }
                IList<string> BCCRecipient { get; set; } 
            }

            public class EmailMessage : IEmailMessage
            {
                public IList<string> Recipient { get; set; }
                public IList<string> BCCRecipient { get; set; }
                public string Subject { get; set; }
                public string Message { get; set; }
                public bool send()
                {
                    return true;
                }
            }
            
            public class SMSMessage : ISMSMessage
            {
                public IList<string> Recipient { get; set; }
                public string Subject { get; set; }
                public string Message { get; set; }
                public bool send()
                {
                    return true;
                }
            }
        }
    }
}