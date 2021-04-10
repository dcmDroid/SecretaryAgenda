using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //MessageBox.Show("changed");
            DataAccess db = new DataAccess();

            People = db.FreeSearch_Employee(freeSearch_Employee.Text);

            UpdateBinding();
        }

        public void CRDUDEmployees_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.freeSearch_Employee.Text = " ";
            //this.freeSearch_Employee.Text = null;
            //MessageBox.Show("refresh");
            //UpdateBinding();
        }

        private void wipeFreeSearchTextBoxButton_E_Click(object sender, EventArgs e)
        {
            freeSearch_Employee.Text = null;
            //MessageBox.Show("wiped");
        }

        private void employeeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUDEmployee modifyEmployee = new CRUDEmployee();

            //var IDValue = this.employeeGrid.CurrentRow.Cells[0].Value;

            modifyEmployee.crudEID.Text = this.employeeGrid.CurrentRow.Cells[0].Value?.ToString() ?? null;
            modifyEmployee.crudEFirstName.Text = this.employeeGrid.CurrentRow.Cells[1].Value?.ToString() ?? null;
            modifyEmployee.crudELastName.Text = this.employeeGrid.CurrentRow.Cells[2].Value?.ToString() ?? null;
            modifyEmployee.crudEEmail.Text = this.employeeGrid.CurrentRow.Cells[3].Value?.ToString() ?? null;
            modifyEmployee.crudECell.Text = this.employeeGrid.CurrentRow.Cells[4].Value?.ToString() ?? null;
            modifyEmployee.crudEPhone.Text = this.employeeGrid.CurrentRow.Cells[5].Value?.ToString() ?? null;
            //modifyEmployee.crudEIsDoc.Text = this.employeeGrid.CurrentRow.Cells[6].Value?.ToString() ?? null;
            modifyEmployee.crudEObligation.Text = employeeGrid.CurrentRow.Cells[7].Value?.ToString() ?? null;
            modifyEmployee.crudEIsDocChck.Checked = Convert.ToBoolean (this.employeeGrid.CurrentRow.Cells[6].Value);
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
    

    }
}
