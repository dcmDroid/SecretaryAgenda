using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecretaryAgenda
{
    public partial class BaseForm : Form
    {
        List<Employee> People = new List<Employee>();
        List<Subject> Classes = new List<Subject>();
        List<Group> Crowds = new List<Group>();
        List<Label> Assembly = new List<Label>();

        public BaseForm()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();
            People = db.FreeSearch_Employee(freeSearch_Employee.Text);
            Classes = db.FreeSearch_Subject(freeSearch_Subject.Text);
            Crowds = db.FreeSearch_Group(freeSearch_Group.Text);
            Assembly = db.FreeSearch_Label(freeSearch_Label.Text);
            
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            employeeGrid.DataSource = People;
            subjectGrid.DataSource = Classes;
            groupGrid.DataSource = Crowds;
            labelGrid.DataSource = Assembly;
           
        }

        private void freeSearch_Employee_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            People = db.FreeSearch_Employee(freeSearch_Employee.Text);

            UpdateBinding();
        }

        public void CRDUDEmployees_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void wipeFreeSearchTextBoxButton_E_Click(object sender, EventArgs e)
        {
            freeSearch_Employee.Text = null;
           
        }

        private void employeeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUDEmployee modifyEmployee = new CRUDEmployee();

            modifyEmployee.crudEID.Text = this.employeeGrid.CurrentRow.Cells[0].Value?.ToString() ?? null;
            modifyEmployee.crudEFirstName.Text = this.employeeGrid.CurrentRow.Cells[1].Value?.ToString() ?? null;
            modifyEmployee.crudELastName.Text = this.employeeGrid.CurrentRow.Cells[2].Value?.ToString() ?? null;
            modifyEmployee.crudEEmail.Text = this.employeeGrid.CurrentRow.Cells[3].Value?.ToString() ?? null;
            modifyEmployee.crudECell.Text = this.employeeGrid.CurrentRow.Cells[4].Value?.ToString() ?? null;
            modifyEmployee.crudEPhone.Text = this.employeeGrid.CurrentRow.Cells[5].Value?.ToString() ?? null;
            modifyEmployee.crudEObligation.Text = employeeGrid.CurrentRow.Cells[7].Value?.ToString() ?? null;
            modifyEmployee.crudEIsDocChck.Checked = Convert.ToBoolean(this.employeeGrid.CurrentRow.Cells[6].Value);
            
            modifyEmployee.FormClosed += UpdateEmployeeGrid_FormClosed;
            modifyEmployee.ShowDialog();
            
        }

        private void UpdateEmployeeGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            freeSearch_Employee.Text = " ";
            freeSearch_Employee.Text = null;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            CRUDEmployee addEmployee = new CRUDEmployee();

            addEmployee.crudEID.Text = null;
            addEmployee.crudEFirstName.Text = null;
            addEmployee.crudELastName.Text = null;
            addEmployee.crudEEmail.Text = null;
            addEmployee.crudECell.Text = null;
            addEmployee.crudEPhone.Text = null;
            //addEmployee.crudEIsDoc.Text = null;
            addEmployee.crudEObligation.Text = null;
            addEmployee.crudEIsDocChck.Checked = false;
            addEmployee.crudEDelete.Visible = false;
            addEmployee.FormClosed += UpdateEmployeeGrid_FormClosed;
            addEmployee.ShowDialog();
        }

        private void Groups_Click_1(object sender, EventArgs e)
        {

        }

        private void TabForm_Enter(object sender, EventArgs e)
        {

        }

        private void subjectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void subjectGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUDSubject modifySubject = new CRUDSubject();

            modifySubject.crudSID.Text = this.subjectGrid.CurrentRow.Cells[0].Value?.ToString() ?? null;
            modifySubject.crudSSubjectCode.Text = this.subjectGrid.CurrentRow.Cells[1].Value?.ToString() ?? null;
            modifySubject.crudSWeeksCount.Text = this.subjectGrid.CurrentRow.Cells[2].Value?.ToString() ?? null;
            modifySubject.crudSSemester.Text = this.subjectGrid.CurrentRow.Cells[3].Value?.ToString() ?? null;
            modifySubject.crudSSemesterID.Text = this.subjectGrid.CurrentRow.Cells[4].Value?.ToString() ?? null;

            modifySubject.crudSStudyDegree.Text = this.subjectGrid.CurrentRow.Cells[5].Value?.ToString() ?? null;
            modifySubject.crudSStudyDegreeID.Text = this.subjectGrid.CurrentRow.Cells[6].Value?.ToString() ?? null;

            modifySubject.crudSHoursLecture.Text = this.subjectGrid.CurrentRow.Cells[7].Value?.ToString() ?? null;
            //modifySubject.crudSHLA.Text = this.subjectGrid.CurrentRow.Cells[8].Value?.ToString() ?? null;

            modifySubject.crudSHoursSeminar.Text = this.subjectGrid.CurrentRow.Cells[8].Value?.ToString() ?? null;
            //modifySubject.crudSHSA.Text = this.subjectGrid.CurrentRow.Cells[10].Value?.ToString() ?? null;

            modifySubject.crudSHoursExcercise.Text = this.subjectGrid.CurrentRow.Cells[9].Value?.ToString() ?? null;
            //modifySubject.crudSHEA.Text = this.subjectGrid.CurrentRow.Cells[12].Value?.ToString() ?? null;

            modifySubject.crudSFinalType.Text = this.subjectGrid.CurrentRow.Cells[10].Value?.ToString() ?? null;
            modifySubject.crudSFinalTypeID.Text = this.subjectGrid.CurrentRow.Cells[11].Value?.ToString() ?? null;

            modifySubject.crudSLanguage.Text = this.subjectGrid.CurrentRow.Cells[12].Value?.ToString() ?? null;
            modifySubject.crudSLanguageID.Text = this.subjectGrid.CurrentRow.Cells[13].Value?.ToString() ?? null;

            modifySubject.FormClosed += UpdateSubjectGrid_FormClosed;
            modifySubject.ShowDialog();
        }
        private void UpdateSubjectGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            freeSearch_Subject.Text = " ";
            freeSearch_Subject.Text = null;
        }
        private void addSubjectBtn_Click(object sender, EventArgs e)
        {
            CRUDSubject modifySubject = new CRUDSubject();

            modifySubject.crudSID.Text = null;
            modifySubject.crudSSubjectCode.Text = null;
            modifySubject.crudSWeeksCount.Text = null;
            modifySubject.crudSSemester.Text = null;
            modifySubject.crudSStudyDegree.Text = null;
            modifySubject.crudSHoursLecture.Text = null;
            modifySubject.crudSHoursSeminar.Text = null;
            modifySubject.crudSHoursExcercise.Text = null;
            modifySubject.crudSFinalType.Text = null;
            modifySubject.crudSLanguage.Text = null;
            modifySubject.crudSDelete.Visible = false;
            modifySubject.FormClosed += UpdateSubjectGrid_FormClosed;
            modifySubject.ShowDialog();
        }

        private void wipeFreeSearchTextBoxButton_S_Click(object sender, EventArgs e)
        {
            freeSearch_Subject.Text = null;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void groupGrid_DoubleClick(object sender, EventArgs e)
        {
            CRUDGroup modifyGroup = new CRUDGroup();

            modifyGroup.crudGID.Text = this.groupGrid.CurrentRow.Cells[0].Value?.ToString() ?? null;
            modifyGroup.crudGGroupCode.Text = this.groupGrid.CurrentRow.Cells[1].Value?.ToString() ?? null;
            modifyGroup.crudGStudyYear.Text = this.groupGrid.CurrentRow.Cells[2].Value?.ToString() ?? null;
            modifyGroup.crudGStudentsCount.Text = this.groupGrid.CurrentRow.Cells[3].Value?.ToString() ?? null;
            modifyGroup.crudGStudyForm.Text = this.groupGrid.CurrentRow.Cells[4].Value?.ToString() ?? null;
            modifyGroup.crudGStudyFormID.Text = this.groupGrid.CurrentRow.Cells[5].Value?.ToString() ?? null;
            modifyGroup.FormClosed += UpdateGroupGrid_FormClosed;
            modifyGroup.ShowDialog();
        }
        private void UpdateGroupGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            freeSearch_Group.Text = " ";
            freeSearch_Group.Text = null;
        }
        private void addGroupBtn_Click(object sender, EventArgs e)
        {
            CRUDGroup modifyGroup = new CRUDGroup();

            modifyGroup.crudGID.Text = null;
            modifyGroup.crudGGroupCode.Text = null;
            modifyGroup.crudGStudyYear.Text = null;
            modifyGroup.crudGStudentsCount.Text = null;
            modifyGroup.crudGStudyForm.Text = null;
            modifyGroup.crudGDelete.Visible = false;
            modifyGroup.FormClosed += UpdateGroupGrid_FormClosed;
            modifyGroup.ShowDialog();
        }
        private void wipeFreeSearchTextBoxButton_G_Click(object sender, EventArgs e)
        {
            freeSearch_Group.Text = null;
        }
        private void labelGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUDLabel modifyLabel = new CRUDLabel();

            modifyLabel.crudLID.Text = this.labelGrid.CurrentRow.Cells[0].Value?.ToString() ?? null;
            //modifyLabel.crudLLabelControlName.Text = this.labelGrid.CurrentRow.Cells[2].Value?.ToString() ?? null;

            //modifyLabel.empCombo.Text = this.labelGrid.CurrentRow.Cells[16].Value?.ToString() ?? null;
            modifyLabel.empCombo.Text = this.labelGrid.CurrentRow.Cells[15].Value?.ToString() ?? null;
            //modifyLabel.crudLEmployeeFullName.Text = this.labelGrid.CurrentRow.Cells[15].Value?.ToString() ?? null;
            modifyLabel.crudLEmpID.Text = this.labelGrid.CurrentRow.Cells[1].Value?.ToString() ?? null;

            modifyLabel.subCombo.Text = this.labelGrid.CurrentRow.Cells[16].Value?.ToString() ?? null;
            //modifyLabel.crudLSubjectCode.Text = this.labelGrid.CurrentRow.Cells[16].Value?.ToString() ?? null;
            modifyLabel.crudLSubID.Text = this.labelGrid.CurrentRow.Cells[2].Value?.ToString() ?? null;

            modifyLabel.groupCombo.Text = this.labelGrid.CurrentRow.Cells[17].Value?.ToString() ?? null;
            //modifyLabel.crudLGroupCode.Text = this.labelGrid.CurrentRow.Cells[17].Value?.ToString() ?? null;
            modifyLabel.crudLGroupID.Text = this.labelGrid.CurrentRow.Cells[3].Value?.ToString() ?? null;

            modifyLabel.crudLConcat.Text = this.labelGrid.CurrentRow.Cells[22].Value?.ToString() ?? null;

            modifyLabel.crudLLang.Text = this.labelGrid.CurrentRow.Cells[18].Value?.ToString() ?? null;
            modifyLabel.crudLLangID.Text = this.labelGrid.CurrentRow.Cells[21].Value?.ToString() ?? null;

            modifyLabel.crudLSem.Text = this.labelGrid.CurrentRow.Cells[19].Value?.ToString() ?? null;
            
            modifyLabel.crudLFinal.Text = this.labelGrid.CurrentRow.Cells[20].Value?.ToString() ?? null;

            modifyLabel.crudLHL.Text = this.labelGrid.CurrentRow.Cells[4].Value?.ToString() ?? null;
            modifyLabel.crudLHS.Text = this.labelGrid.CurrentRow.Cells[6].Value?.ToString() ?? null;
            modifyLabel.crudLHE.Text = this.labelGrid.CurrentRow.Cells[8].Value?.ToString() ?? null;


            modifyLabel.crudLHLAss.Text = this.labelGrid.CurrentRow.Cells[5].Value?.ToString() ?? null;
            modifyLabel.crudLHSAss.Text = this.labelGrid.CurrentRow.Cells[7].Value?.ToString() ?? null;
            modifyLabel.crudLHEAss.Text = this.labelGrid.CurrentRow.Cells[9].Value?.ToString() ?? null;

            modifyLabel.mailAddress.Text = this.labelGrid.CurrentRow.Cells[23].Value?.ToString() ?? null;

            modifyLabel.FormClosed += UpdateLabelGrid_FormClosed;
            modifyLabel.ShowDialog();
        }
        private void UpdateLabelGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Zavřeno");
            freeSearch_Label.Text = " ";
            freeSearch_Label.Text = null;
        }
        private void addLabelBtn_Click(object sender, EventArgs e)
        {
            CRUDLabel modifyLabel = new CRUDLabel();

            modifyLabel.crudLLabelControlName.Text = null;
            modifyLabel.crudLID.Text = null;
            modifyLabel.crudLEmployeeFullName.Text = null;
            modifyLabel.crudLSubjectCode.Text = null;
            modifyLabel.crudLGroupCode.Text = null;
            modifyLabel.crudLSem.Text = null;
            modifyLabel.crudLHLAss.Text = "0";
            modifyLabel.crudLHSAss.Text = "0";
            modifyLabel.crudLHEAss.Text = "0";

            modifyLabel.crudLHL.Text = "0";
            modifyLabel.crudLHS.Text = "0";
            modifyLabel.crudLHE.Text = "0";

            modifyLabel.crudLDelete.Visible = false;
            modifyLabel.FormClosed += UpdateLabelGrid_FormClosed;
            modifyLabel.ShowDialog();
        }


        private void wipeFreeSearchTextBoxButton_L_Click(object sender, EventArgs e)
        {
            freeSearch_Label.Text = null;
        }

        private void freeSearch_Subject_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            Classes = db.FreeSearch_Subject(freeSearch_Subject.Text);

            UpdateBinding();
        }

        private void freeSearch_Group_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            Crowds = db.FreeSearch_Group(freeSearch_Group.Text);

            UpdateBinding();
        }

        private void freeSearch_Label_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            Assembly = db.FreeSearch_Label(freeSearch_Label.Text);

            UpdateBinding();
        }
    }











}
