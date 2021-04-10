using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecretaryAgenda
{
    public partial class CRUDSubject : Form
    {
        List<Enums> Semester = new List<Enums>();
        List<Enums> Degree = new List<Enums>();
        List<Enums> Final = new List<Enums>();
        List<Enums> Language = new List<Enums>();
        List<Subject> Classes = new List<Subject>();

        public CRUDSubject()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();

            Semester = db.Search_Semester();
            Degree = db.Search_Degree();
            Final = db.Search_Final();
            Language = db.Search_Language();
            Classes = db.FreeSearch_Subject(crudSSubjectCode.Text);

            UpdateBinding();
        }
        private void UpdateBinding()
        {
            semesterCombo.ValueMember = "IDEnum";
            semesterCombo.DisplayMember = "EnumString";
            semesterCombo.DataSource = Semester;

            degreeCombo.ValueMember = "IDEnum";
            degreeCombo.DisplayMember = "EnumString";
            degreeCombo.DataSource = Degree;

            finalCombo.ValueMember = "IDEnum";
            finalCombo.DisplayMember = "EnumString";
            finalCombo.DataSource = Final;

            langCombo.ValueMember = "IDEnum";
            langCombo.DisplayMember = "EnumString";
            langCombo.DataSource = Language;

            subHelpGrid.DataSource = Classes;
        }

        private void crudSSave_Click(object sender, EventArgs e)
        {
            //if (this.crudEFirstName.TextLength == 0)
            bool bsc = string.IsNullOrWhiteSpace(this.crudSSubjectCode.Text);
            bool bwc = string.IsNullOrWhiteSpace(this.crudSWeeksCount.Text);
            bool bss = string.IsNullOrWhiteSpace(this.crudSSemester.Text);
            bool bsd = string.IsNullOrWhiteSpace(this.crudSStudyDegree.Text);
            bool bhl = string.IsNullOrWhiteSpace(this.crudSHoursLecture.Text);
            bool bhs = string.IsNullOrWhiteSpace(this.crudSHoursSeminar.Text);
            bool bhe = string.IsNullOrWhiteSpace(this.crudSHoursExcercise.Text);
            bool bft = string.IsNullOrWhiteSpace(this.crudSFinalType.Text);
            bool bla = string.IsNullOrWhiteSpace(this.crudSLanguage.Text);
            bool duplicate = false;

            for (int i = 0; i < subHelpGrid.Rows.Count; i++)
            {
                if (crudSSubjectCode.Text == subHelpGrid.Rows[i].Cells[1].Value.ToString()
                    && this.crudSID.Text == "")

                {
                    duplicate = true;
                    MessageBox.Show("Předmět s tímto názvem již existuje");
                    break;
                }
            }

            if (!duplicate)
            {
                if (bsc == true)
                {
                    MessageBox.Show("Doplňte kód předmětu");
                }
                else if (bwc == true)
                {
                    MessageBox.Show("Doplňte počet týdnů");
                }
                else if (bss == true)
                {
                    MessageBox.Show("Doplňte semestr");
                }
                else if (bsd == true)
                {
                    MessageBox.Show("Doplňte stupeň studia");
                }
                else if (bsd == true)
                {
                    MessageBox.Show("Doplňte stupeň studia");
                }
                else if (bhl == true)
                {
                    MessageBox.Show("Doplňte počet hodin přednášek");
                }
                else if (bhs == true)
                {
                    MessageBox.Show("Doplňte počet hodin seminářů");
                }
                else if (bhe == true)
                {
                    MessageBox.Show("Doplňte počet hodin cvičení");
                }
                else if (bft == true)
                {
                    MessageBox.Show("Doplňte typ ukončení předmětu");
                }
                else if (bla == true)
                {
                    MessageBox.Show("Doplňte jazyk předmětu");
                }
                else
                {
                    DataAccess db = new DataAccess();

                    db.ModifySubject(crudSSubjectCode.Text, crudSWeeksCount.Text, crudSSemesterID.Text, crudSStudyDegreeID.Text, numericSHL.Value, numericSHS.Value, numericSHE.Value, crudSFinalTypeID.Text, crudSLanguageID.Text, crudSID.Text);

                    MessageBox.Show("Záznam uložen");

                    this.Close();
                }
            }


            
        }


        private void crudSDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Opravdu chcete vymazat záznam?", "Vymazání záznamu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                DataAccess db = new DataAccess();

                db.DeleteSubject(crudSID.Text);

                MessageBox.Show("Záznam vymazán");

                this.Close();

            }

        }

        private void CRUDSubject_Load(object sender, EventArgs e)
        {
            semesterCombo.Text = this.crudSSemester.Text?.ToString() ?? null;
            degreeCombo.Text = this.crudSStudyDegree.Text?.ToString() ?? null;
            finalCombo.Text = this.crudSFinalType.Text?.ToString() ?? null;
            langCombo.Text = this.crudSLanguage.Text?.ToString() ?? null;

            if (crudSID.Text != "")
            {
                numericSHL.Value = Convert.ToDecimal(this.crudSHoursLecture.Text);
                numericSHS.Value = Convert.ToDecimal(this.crudSHoursSeminar.Text);
                numericSHE.Value = Convert.ToDecimal(this.crudSHoursExcercise.Text);
            }

            else
            {
                numericSHL.Value = 0;
                numericSHS.Value = 0;
                numericSHE.Value = 0;
            }
                

        }

        private void semesterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            crudSSemester.Text = semesterCombo.Text;

            crudSSemesterID.Text = semesterCombo.SelectedValue.ToString();
        }

        private void degreeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            crudSStudyDegree.Text = degreeCombo.Text;

            crudSStudyDegreeID.Text = degreeCombo.SelectedValue.ToString();
        }

        private void finalCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            crudSFinalType.Text = finalCombo.Text;

            crudSFinalTypeID.Text = finalCombo.SelectedValue.ToString();
        }

        private void langCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            crudSLanguage.Text = langCombo.Text;

            crudSLanguageID.Text = langCombo.SelectedValue.ToString();
        }
    }
}
