using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecretaryAgenda
{
    public partial class CRUDGroup : Form
    {
        List<Enums> Form = new List<Enums>();
        List<Group> Crowds = new List<Group>();
        
        public CRUDGroup()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();

            Form = db.Search_Form();
            Crowds = db.FreeSearch_Group(crudGGroupCode.Text);

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            formCombo.ValueMember = "IDEnum";
            formCombo.DisplayMember = "EnumString";
            formCombo.DataSource = Form;
            groupHelpGrid.DataSource = Crowds;
        }
        private void crudGSave_Click(object sender, EventArgs e)
        {
            //if (this.crudEFirstName.TextLength == 0)
            bool bgc = string.IsNullOrWhiteSpace(this.crudGGroupCode.Text);
            bool bsy = string.IsNullOrWhiteSpace(this.crudGStudyYear.Text);
            bool bsc = string.IsNullOrWhiteSpace(this.crudGStudentsCount.Text);
            bool bsf = string.IsNullOrWhiteSpace(this.crudGStudyForm.Text);
            bool duplicate = false;

            for (int i = 0; i < groupHelpGrid.Rows.Count; i++)
            {
                if (crudGGroupCode.Text == groupHelpGrid.Rows[i].Cells[1].Value.ToString()
                    && this.crudGID.Text == "")

                {
                    duplicate = true;
                    MessageBox.Show("Skupina s tímto názvem již existuje");
                    break;
                }
            }
            if (!duplicate)
            {
                if (bgc == true)
                {
                    MessageBox.Show("Doplňte kód skupiny");
                }
                else if (bsy == true)
                {
                    MessageBox.Show("Doplňte ročník");
                }
                else if (bsc == true)
                {
                    MessageBox.Show("Doplňte počet studentů");
                }
                else if (bsf == true)
                {
                    MessageBox.Show("Doplňte formu studia");
                }

                else

                {
                    DataAccess db = new DataAccess();

                    db.ModifyGroup(crudGGroupCode.Text, crudGStudyYear.Text, crudGStudentsCount.Text, crudGStudyFormID.Text, crudGID.Text);

                    MessageBox.Show("Záznam uložen");
                    this.Close();
                }
            }

            
        }


        private void crudGDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Opravdu chcete vymazat záznam?", "Vymazání záznamu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                DataAccess db = new DataAccess();

                db.DeleteGroup(crudGID.Text);

                MessageBox.Show("Záznam vymazán");

                this.Close();

            }

        }

        private void CRUDGroup_Load(object sender, EventArgs e)
        {
            formCombo.Text = this.crudGStudyForm.Text?.ToString() ?? null;
        }

        private void formCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            crudGStudyForm.Text = formCombo.Text;

            crudGStudyFormID.Text = formCombo.SelectedValue.ToString();
            
        }
    }
}
