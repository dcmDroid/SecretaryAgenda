
namespace SecretaryAgenda
{
    partial class BaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabForm = new System.Windows.Forms.TabControl();
            this.Employees = new System.Windows.Forms.TabPage();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.freeSearch_Employee = new System.Windows.Forms.TextBox();
            this.wipeFreeSearchTextBoxButton_E = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subjects = new System.Windows.Forms.TabPage();
            this.subjectGrid = new System.Windows.Forms.DataGridView();
            this.addSubjectBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.wipeFreeSearchTextBoxButton_S = new System.Windows.Forms.Button();
            this.freeSearch_Subject = new System.Windows.Forms.TextBox();
            this.Groups = new System.Windows.Forms.TabPage();
            this.addGroupBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupGrid = new System.Windows.Forms.DataGridView();
            this.wipeFreeSearchTextBoxButton_G = new System.Windows.Forms.Button();
            this.freeSearch_Group = new System.Windows.Forms.TextBox();
            this.Labels = new System.Windows.Forms.TabPage();
            this.addLabelBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGrid = new System.Windows.Forms.DataGridView();
            this.wipeFreeSearchTextBoxButton_L = new System.Windows.Forms.Button();
            this.freeSearch_Label = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabForm.SuspendLayout();
            this.Employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).BeginInit();
            this.Subjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectGrid)).BeginInit();
            this.Groups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGrid)).BeginInit();
            this.Labels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TabForm
            // 
            this.TabForm.Controls.Add(this.Employees);
            this.TabForm.Controls.Add(this.Subjects);
            this.TabForm.Controls.Add(this.Groups);
            this.TabForm.Controls.Add(this.Labels);
            this.TabForm.Location = new System.Drawing.Point(12, 12);
            this.TabForm.Name = "TabForm";
            this.TabForm.SelectedIndex = 0;
            this.TabForm.Size = new System.Drawing.Size(1150, 737);
            this.TabForm.TabIndex = 0;
            this.TabForm.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.TabForm.Enter += new System.EventHandler(this.TabForm_Enter);
            // 
            // Employees
            // 
            this.Employees.Controls.Add(this.addEmployeeBtn);
            this.Employees.Controls.Add(this.freeSearch_Employee);
            this.Employees.Controls.Add(this.wipeFreeSearchTextBoxButton_E);
            this.Employees.Controls.Add(this.label1);
            this.Employees.Controls.Add(this.employeeGrid);
            this.Employees.Location = new System.Drawing.Point(4, 24);
            this.Employees.Name = "Employees";
            this.Employees.Padding = new System.Windows.Forms.Padding(3);
            this.Employees.Size = new System.Drawing.Size(1142, 709);
            this.Employees.TabIndex = 0;
            this.Employees.Text = "Zaměstnanci";
            this.Employees.UseVisualStyleBackColor = true;
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Location = new System.Drawing.Point(29, 668);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(134, 23);
            this.addEmployeeBtn.TabIndex = 5;
            this.addEmployeeBtn.Text = "Vytvořit záznam";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // freeSearch_Employee
            // 
            this.freeSearch_Employee.Location = new System.Drawing.Point(94, 14);
            this.freeSearch_Employee.Name = "freeSearch_Employee";
            this.freeSearch_Employee.Size = new System.Drawing.Size(181, 23);
            this.freeSearch_Employee.TabIndex = 4;
            this.freeSearch_Employee.TextChanged += new System.EventHandler(this.freeSearch_Employee_TextChanged);
            // 
            // wipeFreeSearchTextBoxButton_E
            // 
            this.wipeFreeSearchTextBoxButton_E.Location = new System.Drawing.Point(281, 14);
            this.wipeFreeSearchTextBoxButton_E.Name = "wipeFreeSearchTextBoxButton_E";
            this.wipeFreeSearchTextBoxButton_E.Size = new System.Drawing.Size(97, 23);
            this.wipeFreeSearchTextBoxButton_E.TabIndex = 3;
            this.wipeFreeSearchTextBoxButton_E.Text = "vymazat text";
            this.wipeFreeSearchTextBoxButton_E.UseVisualStyleBackColor = true;
            this.wipeFreeSearchTextBoxButton_E.Click += new System.EventHandler(this.wipeFreeSearchTextBoxButton_E_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vyhledávání";
            // 
            // employeeGrid
            // 
            this.employeeGrid.AllowUserToAddRows = false;
            this.employeeGrid.AllowUserToDeleteRows = false;
            this.employeeGrid.AllowUserToResizeColumns = false;
            this.employeeGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employeeGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column2,
            this.Column3,
            this.Column9,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column1});
            this.employeeGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.employeeGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.employeeGrid.Location = new System.Drawing.Point(29, 53);
            this.employeeGrid.MultiSelect = false;
            this.employeeGrid.Name = "employeeGrid";
            this.employeeGrid.ReadOnly = true;
            this.employeeGrid.RowHeadersVisible = false;
            this.employeeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.employeeGrid.RowTemplate.Height = 25;
            this.employeeGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.employeeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeGrid.Size = new System.Drawing.Size(1100, 600);
            this.employeeGrid.TabIndex = 0;
            this.employeeGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeGrid_CellDoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.DataPropertyName = "IDEmployee";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "EmployeeFullName";
            this.Column2.HeaderText = "Zaměstnanec";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 103;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FirstName";
            this.Column3.HeaderText = "Jméno";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "LastName";
            this.Column9.HeaderText = "Příjmení";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "EmailAddress";
            this.Column4.HeaderText = "Emailová adresa";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 107;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CellPhone";
            this.Column5.HeaderText = "Mobilní telefon";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Phone";
            this.Column6.HeaderText = "Pevná linka";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.DataPropertyName = "IsDoc";
            this.Column7.HeaderText = "Doktorand";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.TrueValue = "Doktorand";
            this.Column7.Width = 88;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column8.DataPropertyName = "Obligation";
            this.Column8.HeaderText = "Úvazek";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 69;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "OverallScorePoints";
            this.Column1.HeaderText = "Počet bodů";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Subjects
            // 
            this.Subjects.Controls.Add(this.subjectGrid);
            this.Subjects.Controls.Add(this.addSubjectBtn);
            this.Subjects.Controls.Add(this.label2);
            this.Subjects.Controls.Add(this.wipeFreeSearchTextBoxButton_S);
            this.Subjects.Controls.Add(this.freeSearch_Subject);
            this.Subjects.Location = new System.Drawing.Point(4, 24);
            this.Subjects.Name = "Subjects";
            this.Subjects.Padding = new System.Windows.Forms.Padding(3);
            this.Subjects.Size = new System.Drawing.Size(1142, 709);
            this.Subjects.TabIndex = 1;
            this.Subjects.Text = "Předměty";
            this.Subjects.UseVisualStyleBackColor = true;
            // 
            // subjectGrid
            // 
            this.subjectGrid.AllowUserToAddRows = false;
            this.subjectGrid.AllowUserToDeleteRows = false;
            this.subjectGrid.AllowUserToResizeColumns = false;
            this.subjectGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subjectGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.subjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subjectGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.subjectGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.subjectGrid.Location = new System.Drawing.Point(29, 53);
            this.subjectGrid.MultiSelect = false;
            this.subjectGrid.Name = "subjectGrid";
            this.subjectGrid.ReadOnly = true;
            this.subjectGrid.RowHeadersVisible = false;
            this.subjectGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.subjectGrid.RowTemplate.Height = 25;
            this.subjectGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectGrid.Size = new System.Drawing.Size(1100, 600);
            this.subjectGrid.TabIndex = 6;
            this.subjectGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectGrid_CellDoubleClick);
            // 
            // addSubjectBtn
            // 
            this.addSubjectBtn.Location = new System.Drawing.Point(29, 668);
            this.addSubjectBtn.Name = "addSubjectBtn";
            this.addSubjectBtn.Size = new System.Drawing.Size(134, 23);
            this.addSubjectBtn.TabIndex = 5;
            this.addSubjectBtn.Text = "Vytvořit záznam";
            this.addSubjectBtn.UseVisualStyleBackColor = true;
            this.addSubjectBtn.Click += new System.EventHandler(this.addSubjectBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vyhledávání";
            // 
            // wipeFreeSearchTextBoxButton_S
            // 
            this.wipeFreeSearchTextBoxButton_S.Location = new System.Drawing.Point(281, 14);
            this.wipeFreeSearchTextBoxButton_S.Name = "wipeFreeSearchTextBoxButton_S";
            this.wipeFreeSearchTextBoxButton_S.Size = new System.Drawing.Size(97, 23);
            this.wipeFreeSearchTextBoxButton_S.TabIndex = 2;
            this.wipeFreeSearchTextBoxButton_S.Text = "vymazat text";
            this.wipeFreeSearchTextBoxButton_S.UseVisualStyleBackColor = true;
            this.wipeFreeSearchTextBoxButton_S.Click += new System.EventHandler(this.wipeFreeSearchTextBoxButton_S_Click);
            // 
            // freeSearch_Subject
            // 
            this.freeSearch_Subject.Location = new System.Drawing.Point(94, 14);
            this.freeSearch_Subject.Name = "freeSearch_Subject";
            this.freeSearch_Subject.Size = new System.Drawing.Size(181, 23);
            this.freeSearch_Subject.TabIndex = 1;
            this.freeSearch_Subject.TextChanged += new System.EventHandler(this.freeSearch_Subject_TextChanged);
            // 
            // Groups
            // 
            this.Groups.Controls.Add(this.addGroupBtn);
            this.Groups.Controls.Add(this.label3);
            this.Groups.Controls.Add(this.groupGrid);
            this.Groups.Controls.Add(this.wipeFreeSearchTextBoxButton_G);
            this.Groups.Controls.Add(this.freeSearch_Group);
            this.Groups.Location = new System.Drawing.Point(4, 24);
            this.Groups.Name = "Groups";
            this.Groups.Padding = new System.Windows.Forms.Padding(3);
            this.Groups.Size = new System.Drawing.Size(1142, 709);
            this.Groups.TabIndex = 2;
            this.Groups.Text = "Skupiny";
            this.Groups.UseVisualStyleBackColor = true;
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Location = new System.Drawing.Point(29, 668);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(134, 23);
            this.addGroupBtn.TabIndex = 4;
            this.addGroupBtn.Text = "Vytvořit záznam";
            this.addGroupBtn.UseVisualStyleBackColor = true;
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vyhledávání";
            // 
            // groupGrid
            // 
            this.groupGrid.AllowUserToAddRows = false;
            this.groupGrid.AllowUserToDeleteRows = false;
            this.groupGrid.AllowUserToResizeColumns = false;
            this.groupGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.groupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.groupGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.groupGrid.Location = new System.Drawing.Point(29, 53);
            this.groupGrid.MultiSelect = false;
            this.groupGrid.Name = "groupGrid";
            this.groupGrid.ReadOnly = true;
            this.groupGrid.RowHeadersVisible = false;
            this.groupGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.groupGrid.RowTemplate.Height = 25;
            this.groupGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.groupGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupGrid.Size = new System.Drawing.Size(1100, 600);
            this.groupGrid.TabIndex = 2;
            this.groupGrid.DoubleClick += new System.EventHandler(this.groupGrid_DoubleClick);
            // 
            // wipeFreeSearchTextBoxButton_G
            // 
            this.wipeFreeSearchTextBoxButton_G.Location = new System.Drawing.Point(281, 14);
            this.wipeFreeSearchTextBoxButton_G.Name = "wipeFreeSearchTextBoxButton_G";
            this.wipeFreeSearchTextBoxButton_G.Size = new System.Drawing.Size(97, 23);
            this.wipeFreeSearchTextBoxButton_G.TabIndex = 1;
            this.wipeFreeSearchTextBoxButton_G.Text = "vymazat text";
            this.wipeFreeSearchTextBoxButton_G.UseVisualStyleBackColor = true;
            this.wipeFreeSearchTextBoxButton_G.Click += new System.EventHandler(this.wipeFreeSearchTextBoxButton_G_Click);
            // 
            // freeSearch_Group
            // 
            this.freeSearch_Group.Location = new System.Drawing.Point(94, 14);
            this.freeSearch_Group.Name = "freeSearch_Group";
            this.freeSearch_Group.Size = new System.Drawing.Size(181, 23);
            this.freeSearch_Group.TabIndex = 0;
            this.freeSearch_Group.TextChanged += new System.EventHandler(this.freeSearch_Group_TextChanged);
            // 
            // Labels
            // 
            this.Labels.Controls.Add(this.addLabelBtn);
            this.Labels.Controls.Add(this.label4);
            this.Labels.Controls.Add(this.labelGrid);
            this.Labels.Controls.Add(this.wipeFreeSearchTextBoxButton_L);
            this.Labels.Controls.Add(this.freeSearch_Label);
            this.Labels.Location = new System.Drawing.Point(4, 24);
            this.Labels.Name = "Labels";
            this.Labels.Padding = new System.Windows.Forms.Padding(3);
            this.Labels.Size = new System.Drawing.Size(1142, 709);
            this.Labels.TabIndex = 3;
            this.Labels.Text = "Štítky";
            this.Labels.UseVisualStyleBackColor = true;
            // 
            // addLabelBtn
            // 
            this.addLabelBtn.Location = new System.Drawing.Point(29, 672);
            this.addLabelBtn.Name = "addLabelBtn";
            this.addLabelBtn.Size = new System.Drawing.Size(130, 23);
            this.addLabelBtn.TabIndex = 4;
            this.addLabelBtn.Text = "Vytvořit záznam";
            this.addLabelBtn.UseVisualStyleBackColor = true;
            this.addLabelBtn.Click += new System.EventHandler(this.addLabelBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vyhledávání";
            // 
            // labelGrid
            // 
            this.labelGrid.AllowUserToAddRows = false;
            this.labelGrid.AllowUserToDeleteRows = false;
            this.labelGrid.AllowUserToResizeColumns = false;
            this.labelGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.labelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labelGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.labelGrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGrid.Location = new System.Drawing.Point(29, 53);
            this.labelGrid.Name = "labelGrid";
            this.labelGrid.RowHeadersVisible = false;
            this.labelGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.labelGrid.RowTemplate.Height = 25;
            this.labelGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.labelGrid.Size = new System.Drawing.Size(1100, 600);
            this.labelGrid.TabIndex = 2;
            this.labelGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.labelGrid_CellDoubleClick);
            // 
            // wipeFreeSearchTextBoxButton_L
            // 
            this.wipeFreeSearchTextBoxButton_L.Location = new System.Drawing.Point(281, 14);
            this.wipeFreeSearchTextBoxButton_L.Name = "wipeFreeSearchTextBoxButton_L";
            this.wipeFreeSearchTextBoxButton_L.Size = new System.Drawing.Size(97, 23);
            this.wipeFreeSearchTextBoxButton_L.TabIndex = 1;
            this.wipeFreeSearchTextBoxButton_L.Text = "vymazat text";
            this.wipeFreeSearchTextBoxButton_L.UseVisualStyleBackColor = true;
            this.wipeFreeSearchTextBoxButton_L.Click += new System.EventHandler(this.wipeFreeSearchTextBoxButton_L_Click);
            // 
            // freeSearch_Label
            // 
            this.freeSearch_Label.Location = new System.Drawing.Point(94, 14);
            this.freeSearch_Label.Name = "freeSearch_Label";
            this.freeSearch_Label.Size = new System.Drawing.Size(181, 23);
            this.freeSearch_Label.TabIndex = 0;
            this.freeSearch_Label.TextChanged += new System.EventHandler(this.freeSearch_Label_TextChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDEmployee";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Jméno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Příjmení";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EmailAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "Emailová adresa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CellPhone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mobilní telefon";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pevná linka";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsDoc";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Doktorand";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.TrueValue = "Doktorand";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Obligation";
            this.dataGridViewTextBoxColumn7.HeaderText = "Úvazek";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OverallScorePoints";
            this.dataGridViewTextBoxColumn8.HeaderText = "Počet bodů";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.TabForm);
            this.Name = "BaseForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Agenda Tajemníka Fakulty";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.TabForm.ResumeLayout(false);
            this.Employees.ResumeLayout(false);
            this.Employees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).EndInit();
            this.Subjects.ResumeLayout(false);
            this.Subjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectGrid)).EndInit();
            this.Groups.ResumeLayout(false);
            this.Groups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGrid)).EndInit();
            this.Labels.ResumeLayout(false);
            this.Labels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabForm;
        private System.Windows.Forms.TabPage Employees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wipeFreeSearchTextBoxButton_E;
        private System.Windows.Forms.DataGridView employeeGrid;
        private System.Windows.Forms.Button addEmployeeBtn;
        //private System.Windows.Forms.DataGridView subjectGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TabPage Subjects;
        private System.Windows.Forms.Button wipeFreeSearchTextBoxButton_S;
        private System.Windows.Forms.TabPage Groups;
        private System.Windows.Forms.DataGridView groupGrid;
        private System.Windows.Forms.Button wipeFreeSearchTextBoxButton_G;
        private System.Windows.Forms.TabPage Labels;
        private System.Windows.Forms.DataGridView labelGrid;
        private System.Windows.Forms.Button wipeFreeSearchTextBoxButton_L;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addSubjectBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView subjectGrid;
        private System.Windows.Forms.Button addGroupBtn;
        private System.Windows.Forms.Button addLabelBtn;
        public System.Windows.Forms.TextBox freeSearch_Employee;
        public System.Windows.Forms.TextBox freeSearch_Subject;
        public System.Windows.Forms.TextBox freeSearch_Group;
        public System.Windows.Forms.TextBox freeSearch_Label;
    }
}

