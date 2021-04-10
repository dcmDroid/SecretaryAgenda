
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDEmployee));
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
            this.crudEFullName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.empHelpGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empHelpGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // crudESave
            // 
            resources.ApplyResources(this.crudESave, "crudESave");
            this.crudESave.Name = "crudESave";
            this.crudESave.UseVisualStyleBackColor = true;
            this.crudESave.Click += new System.EventHandler(this.crudESave_Click);
            // 
            // crudELastName
            // 
            resources.ApplyResources(this.crudELastName, "crudELastName");
            this.crudELastName.Name = "crudELastName";
            // 
            // crudEEmail
            // 
            resources.ApplyResources(this.crudEEmail, "crudEEmail");
            this.crudEEmail.Name = "crudEEmail";
            // 
            // crudECell
            // 
            resources.ApplyResources(this.crudECell, "crudECell");
            this.crudECell.Name = "crudECell";
            // 
            // crudEPhone
            // 
            resources.ApplyResources(this.crudEPhone, "crudEPhone");
            this.crudEPhone.Name = "crudEPhone";
            // 
            // crudEObligation
            // 
            this.crudEObligation.AcceptsReturn = true;
            resources.ApplyResources(this.crudEObligation, "crudEObligation");
            this.crudEObligation.Name = "crudEObligation";
            this.crudEObligation.TextChanged += new System.EventHandler(this.crudEObligation_TextChanged);
            this.crudEObligation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.crudEObligation_KeyPress);
            this.crudEObligation.Leave += new System.EventHandler(this.crudEObligation_Leave);
            // 
            // crudEID
            // 
            resources.ApplyResources(this.crudEID, "crudEID");
            this.crudEID.Name = "crudEID";
            // 
            // crudEFirstName
            // 
            this.crudEFirstName.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.crudEFirstName, "crudEFirstName");
            this.crudEFirstName.Name = "crudEFirstName";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // crudEIsDocChck
            // 
            resources.ApplyResources(this.crudEIsDocChck, "crudEIsDocChck");
            this.crudEIsDocChck.Name = "crudEIsDocChck";
            this.crudEIsDocChck.UseVisualStyleBackColor = true;
            // 
            // crudEDelete
            // 
            resources.ApplyResources(this.crudEDelete, "crudEDelete");
            this.crudEDelete.Name = "crudEDelete";
            this.crudEDelete.UseVisualStyleBackColor = true;
            this.crudEDelete.Click += new System.EventHandler(this.crudEDelete_Click);
            // 
            // crudEFullName
            // 
            resources.ApplyResources(this.crudEFullName, "crudEFullName");
            this.crudEFullName.Name = "crudEFullName";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // empHelpGrid
            // 
            this.empHelpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.empHelpGrid, "empHelpGrid");
            this.empHelpGrid.Name = "empHelpGrid";
            this.empHelpGrid.RowTemplate.Height = 25;
            // 
            // CRUDEmployee
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.empHelpGrid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.crudEFullName);
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
            this.Load += new System.EventHandler(this.CRUDEmployee_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.empHelpGrid)).EndInit();
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
        public System.Windows.Forms.TextBox crudEFullName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView empHelpGrid;
    }
}