
namespace SecretaryAgenda
{
    partial class CRUDGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDGroup));
            this.crudGSave = new System.Windows.Forms.Button();
            this.crudGStudyYear = new System.Windows.Forms.TextBox();
            this.crudGStudentsCount = new System.Windows.Forms.TextBox();
            this.crudGStudyForm = new System.Windows.Forms.TextBox();
            this.crudGID = new System.Windows.Forms.TextBox();
            this.crudGGroupCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crudGDelete = new System.Windows.Forms.Button();
            this.formCombo = new System.Windows.Forms.ComboBox();
            this.crudGStudyFormID = new System.Windows.Forms.TextBox();
            this.groupHelpGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupHelpGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // crudGSave
            // 
            resources.ApplyResources(this.crudGSave, "crudGSave");
            this.crudGSave.Name = "crudGSave";
            this.crudGSave.UseVisualStyleBackColor = true;
            this.crudGSave.Click += new System.EventHandler(this.crudGSave_Click);
            // 
            // crudGStudyYear
            // 
            resources.ApplyResources(this.crudGStudyYear, "crudGStudyYear");
            this.crudGStudyYear.Name = "crudGStudyYear";
            // 
            // crudGStudentsCount
            // 
            resources.ApplyResources(this.crudGStudentsCount, "crudGStudentsCount");
            this.crudGStudentsCount.Name = "crudGStudentsCount";
            // 
            // crudGStudyForm
            // 
            resources.ApplyResources(this.crudGStudyForm, "crudGStudyForm");
            this.crudGStudyForm.Name = "crudGStudyForm";
            // 
            // crudGID
            // 
            resources.ApplyResources(this.crudGID, "crudGID");
            this.crudGID.Name = "crudGID";
            // 
            // crudGGroupCode
            // 
            this.crudGGroupCode.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.crudGGroupCode, "crudGGroupCode");
            this.crudGGroupCode.Name = "crudGGroupCode";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
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
            // crudGDelete
            // 
            resources.ApplyResources(this.crudGDelete, "crudGDelete");
            this.crudGDelete.Name = "crudGDelete";
            this.crudGDelete.UseVisualStyleBackColor = true;
            this.crudGDelete.Click += new System.EventHandler(this.crudGDelete_Click);
            // 
            // formCombo
            // 
            this.formCombo.FormattingEnabled = true;
            resources.ApplyResources(this.formCombo, "formCombo");
            this.formCombo.Name = "formCombo";
            this.formCombo.SelectedIndexChanged += new System.EventHandler(this.formCombo_SelectedIndexChanged);
            // 
            // crudGStudyFormID
            // 
            resources.ApplyResources(this.crudGStudyFormID, "crudGStudyFormID");
            this.crudGStudyFormID.Name = "crudGStudyFormID";
            // 
            // groupHelpGrid
            // 
            this.groupHelpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.groupHelpGrid, "groupHelpGrid");
            this.groupHelpGrid.Name = "groupHelpGrid";
            this.groupHelpGrid.RowTemplate.Height = 25;
            // 
            // CRUDGroup
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupHelpGrid);
            this.Controls.Add(this.crudGStudyFormID);
            this.Controls.Add(this.formCombo);
            this.Controls.Add(this.crudGDelete);
            this.Controls.Add(this.crudGSave);
            this.Controls.Add(this.crudGStudyYear);
            this.Controls.Add(this.crudGStudentsCount);
            this.Controls.Add(this.crudGStudyForm);
            this.Controls.Add(this.crudGID);
            this.Controls.Add(this.crudGGroupCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CRUDGroup";
            this.Load += new System.EventHandler(this.CRUDGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupHelpGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button crudGSave;
        public System.Windows.Forms.TextBox crudGStudyYear;
        public System.Windows.Forms.TextBox crudGStudentsCount;
        public System.Windows.Forms.TextBox crudGStudyForm;
        public System.Windows.Forms.TextBox crudGID;
        public System.Windows.Forms.TextBox crudGGroupCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button crudGDelete;
        public System.Windows.Forms.TextBox crudGStudyFormID;
        public System.Windows.Forms.ComboBox formCombo;
        private System.Windows.Forms.DataGridView groupHelpGrid;
    }
}