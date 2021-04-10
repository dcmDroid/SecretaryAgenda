
namespace SecretaryAgenda
{
    partial class CRUDEmployee
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.crudESave = new System.Windows.Forms.Button();
            this.crudELastName = new System.Windows.Forms.TextBox();
            this.crudEEmail = new System.Windows.Forms.TextBox();
            this.crudECell = new System.Windows.Forms.TextBox();
            this.crudEPhone = new System.Windows.Forms.TextBox();
            this.crudEObligation = new System.Windows.Forms.TextBox();
            this.crudEID = new System.Windows.Forms.TextBox();
            this.crudEFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crudEIsDocChck = new System.Windows.Forms.CheckBox();
            this.crudEDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(69, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Úvazek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Doktorand";
            // 
            // crudESave
            // 
            this.crudESave.Location = new System.Drawing.Point(69, 278);
            this.crudESave.Name = "crudESave";
            this.crudESave.Size = new System.Drawing.Size(213, 23);
            this.crudESave.TabIndex = 31;
            this.crudESave.Text = "Uložit záznam";
            this.crudESave.UseVisualStyleBackColor = true;
            this.crudESave.Click += new System.EventHandler(this.crudESave_Click);
            // 
            // crudELastName
            // 
            this.crudELastName.Location = new System.Drawing.Point(163, 65);
            this.crudELastName.Name = "crudELastName";
            this.crudELastName.Size = new System.Drawing.Size(405, 23);
            this.crudELastName.TabIndex = 30;
            // 
            // crudEEmail
            // 
            this.crudEEmail.Location = new System.Drawing.Point(163, 94);
            this.crudEEmail.Name = "crudEEmail";
            this.crudEEmail.Size = new System.Drawing.Size(405, 23);
            this.crudEEmail.TabIndex = 29;
            // 
            // crudECell
            // 
            this.crudECell.Location = new System.Drawing.Point(163, 123);
            this.crudECell.Name = "crudECell";
            this.crudECell.Size = new System.Drawing.Size(257, 23);
            this.crudECell.TabIndex = 28;
            // 
            // crudEPhone
            // 
            this.crudEPhone.Location = new System.Drawing.Point(163, 152);
            this.crudEPhone.Name = "crudEPhone";
            this.crudEPhone.Size = new System.Drawing.Size(257, 23);
            this.crudEPhone.TabIndex = 27;
            // 
            // crudEObligation
            // 
            this.crudEObligation.AcceptsReturn = true;
            this.crudEObligation.Location = new System.Drawing.Point(163, 211);
            this.crudEObligation.Name = "crudEObligation";
            this.crudEObligation.Size = new System.Drawing.Size(51, 23);
            this.crudEObligation.TabIndex = 25;
            this.crudEObligation.TextChanged += new System.EventHandler(this.crudEObligation_TextChanged);
            this.crudEObligation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.crudEObligation_KeyPress);
            this.crudEObligation.Leave += new System.EventHandler(this.crudEObligation_Leave);
            // 
            // crudEID
            // 
            this.crudEID.Location = new System.Drawing.Point(416, 206);
            this.crudEID.Name = "crudEID";
            this.crudEID.Size = new System.Drawing.Size(113, 23);
            this.crudEID.TabIndex = 24;
            this.crudEID.Visible = false;
            // 
            // crudEFirstName
            // 
            this.crudEFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.crudEFirstName.Location = new System.Drawing.Point(163, 35);
            this.crudEFirstName.Name = "crudEFirstName";
            this.crudEFirstName.Size = new System.Drawing.Size(405, 23);
            this.crudEFirstName.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID_hidden";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pevná linka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mobilní telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Příjmení";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Jméno";
            // 
            // crudEIsDocChck
            // 
            this.crudEIsDocChck.AutoSize = true;
            this.crudEIsDocChck.Location = new System.Drawing.Point(163, 185);
            this.crudEIsDocChck.Name = "crudEIsDocChck";
            this.crudEIsDocChck.Size = new System.Drawing.Size(15, 14);
            this.crudEIsDocChck.TabIndex = 34;
            this.crudEIsDocChck.UseVisualStyleBackColor = true;
            // 
            // crudEDelete
            // 
            this.crudEDelete.Location = new System.Drawing.Point(355, 278);
            this.crudEDelete.Name = "crudEDelete";
            this.crudEDelete.Size = new System.Drawing.Size(213, 23);
            this.crudEDelete.TabIndex = 37;
            this.crudEDelete.Text = "Vymazat záznam";
            this.crudEDelete.UseVisualStyleBackColor = true;
            this.crudEDelete.Click += new System.EventHandler(this.crudEDelete_Click);
            // 
            // CRUDEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(645, 352);
            this.Controls.Add(this.crudEDelete);
            this.Controls.Add(this.crudEIsDocChck);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.crudESave);
            this.Controls.Add(this.crudELastName);
            this.Controls.Add(this.crudEEmail);
            this.Controls.Add(this.crudECell);
            this.Controls.Add(this.crudEPhone);
            this.Controls.Add(this.crudEObligation);
            this.Controls.Add(this.crudEID);
            this.Controls.Add(this.crudEFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CRUDEmployee";
            this.Text = "Úprava záznamu zaměstnance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button crudESave;
        public System.Windows.Forms.TextBox crudELastName;
        public System.Windows.Forms.TextBox crudEEmail;
        public System.Windows.Forms.TextBox crudECell;
        public System.Windows.Forms.TextBox crudEPhone;
        public System.Windows.Forms.TextBox crudEObligation;
        public System.Windows.Forms.TextBox crudEID;
        public System.Windows.Forms.TextBox crudEFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox crudEIsDocChck;
        public System.Windows.Forms.Button crudEDelete;
    }
}