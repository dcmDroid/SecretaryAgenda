using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Text;

namespace SecretaryAgenda
{
    public class Email
    {
        public MailAddress From { get; set; }
        public MailAddress To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

      
        
    }
}
