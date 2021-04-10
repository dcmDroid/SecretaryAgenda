using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace SecretaryAgenda
{
    public partial class MailSender : Form
    {
        public MailSender()
        {
            InitializeComponent();
        }

        private void mailSend_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("dcmickey@seznam.cz");
            message.To.Add(new MailAddress(this.senderMailAddress.Text));
            message.Subject = this.senderLabelCode.Text;
            message.Body = senderContent.Text;

            smtp.Port = 587;
            smtp.Host = "smtp.seznam.cz";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("dcmickey@seznam.cz", "xxxxxxxxxx");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);

            MessageBox.Show("Email odeslán");

            this.Close();
        }
    }
}
