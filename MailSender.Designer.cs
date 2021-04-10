
namespace SecretaryAgenda
{
    partial class MailSender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mailSend = new System.Windows.Forms.Button();
            this.senderMailAddress = new System.Windows.Forms.TextBox();
            this.senderLabelCode = new System.Windows.Forms.TextBox();
            this.senderContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // mailSend
            // 
            this.mailSend.Location = new System.Drawing.Point(671, 399);
            this.mailSend.Name = "mailSend";
            this.mailSend.Size = new System.Drawing.Size(75, 23);
            this.mailSend.TabIndex = 0;
            this.mailSend.Text = "Odeslat";
            this.mailSend.UseVisualStyleBackColor = true;
            this.mailSend.Click += new System.EventHandler(this.mailSend_Click);
            // 
            // senderMailAddress
            // 
            this.senderMailAddress.Location = new System.Drawing.Point(81, 376);
            this.senderMailAddress.Name = "senderMailAddress";
            this.senderMailAddress.Size = new System.Drawing.Size(208, 23);
            this.senderMailAddress.TabIndex = 1;
            // 
            // senderLabelCode
            // 
            this.senderLabelCode.Location = new System.Drawing.Point(81, 415);
            this.senderLabelCode.Name = "senderLabelCode";
            this.senderLabelCode.Size = new System.Drawing.Size(208, 23);
            this.senderLabelCode.TabIndex = 2;
            // 
            // senderContent
            // 
            this.senderContent.Location = new System.Drawing.Point(36, 30);
            this.senderContent.Name = "senderContent";
            this.senderContent.Size = new System.Drawing.Size(709, 329);
            this.senderContent.TabIndex = 3;
            this.senderContent.Text = "";
            // 
            // MailSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.senderContent);
            this.Controls.Add(this.senderLabelCode);
            this.Controls.Add(this.senderMailAddress);
            this.Controls.Add(this.mailSend);
            this.Name = "MailSender";
            this.Text = "MailSender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mailSend;
        public System.Windows.Forms.TextBox senderMailAddress;
        public System.Windows.Forms.TextBox senderLabelCode;
        public System.Windows.Forms.RichTextBox senderContent;
    }
}