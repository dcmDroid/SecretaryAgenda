using System;
using System.Collections.Generic;


using System.Windows.Forms;

namespace SecretaryAgenda
{
    public partial class CRUDLabel : Form
    {
        List<Employee> People = new List<Employee>();
        List<Subject> Classes = new List<Subject>();
        List<Group> Crowds = new List<Group>();

        List<Label> Assembly = new List<Label>();

        public CRUDLabel()
        {
            InitializeComponent();

            //crudLFirstName.Text = 

            DataAccess db = new DataAccess();

            People = db.FreeSearch_Employee(crudLEmployeeFullName.Text);
            Classes = db.FreeSearch_Subject(crudLSubjectCode.Text);
            Crowds = db.FreeSearch_Group(crudLGroupCode.Text);
            Assembly = db.FreeSearch_Label(crudLLabelControlName.Text);


            //predmety = db.Search_Subject();

            //Enumerables = db.Search_Enums(crudLEnuSemString.Text);

            UpdateBinding();


            //Classes = db.FreeSearch_Subject(freeSearch_Subject.Text);
            //Crowds = db.FreeSearch_Group(freeSearch_Group.Text);
        }


        private void UpdateBinding()
        {

            empCombo.ValueMember = "IDEmployee";
            empCombo.DisplayMember = "EmployeeFullName";
            empCombo.DataSource = People;

            subCombo.ValueMember = "IDSubject";
            subCombo.DisplayMember = "SubjectCode";
            subCombo.DataSource = Classes;

            groupCombo.ValueMember = "IDGroup";
            groupCombo.DisplayMember = "GroupCode";
            groupCombo.DataSource = Crowds;

            subHelpGrid.DataSource = Classes;
            labHelpGrid.DataSource = Assembly;

        }

        private void empCombo_SelectedIndexChanged(object sender, EventArgs e)
        {


            crudLEmployeeFullName.Text = empCombo.Text;

            crudLEmpID.Text = empCombo.SelectedValue.ToString();

            
        }


        private void crudlSave_Click(object sender, EventArgs e)       

        {
            
            bool bfn = string.IsNullOrWhiteSpace(this.crudLEmployeeFullName.Text);
            bool bsu = string.IsNullOrWhiteSpace(this.crudLSubjectCode.Text);
            bool bgr = string.IsNullOrWhiteSpace(this.crudLGroupCode.Text);

            bool bnl = this.numericLHL.Value.Equals(0);
            bool bns = this.numericLHS.Value.Equals(0);
            bool bne = this.numericLHE.Value.Equals(0);

            bool duplicate = false;


            for (int i = 0; i < labHelpGrid.Rows.Count; i++)
            {
                if (crudLLabelControlName.Text ==
                    labHelpGrid.Rows[i].Cells[15].Value.ToString() + ' ' +
                    labHelpGrid.Rows[i].Cells[16].Value.ToString() + ' ' +
                    labHelpGrid.Rows[i].Cells[17].Value.ToString()
                    && this.crudLID.Text == "")

                {
                    duplicate = true;
                    MessageBox.Show("Kombinace zaměstnance, předmětu a skupiny již existuje");
                    break;
                }
            }

            if (!duplicate)
            {
                if (bfn == true)
                {
                    MessageBox.Show("Vyberte zaměstanance");
                }

                else if (bsu == true)
                {
                    MessageBox.Show("Vyberte předmět");
                }

                else if (bgr == true)
                {
                    MessageBox.Show("Vyberte skupinu");
                }

                else if (bnl == true || bns == true || bne == true)

                {
                    MessageBox.Show("Přidělte hodiny přednášky, semináře nebo cvičení");
                }


                else

                {

                    DataAccess db = new DataAccess();

                    db.ModifyLabel(crudLSubID.Text, crudLGroupID.Text, crudLEmpID.Text, numericLHL.Value, numericLHS.Value, numericLHE.Value, crudLID.Text);

                    MessageBox.Show("Záznam uložen");

                    this.Close();
                }
            }

            
        }


        private void crudLDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Opravdu chcete vymazat záznam?", "Vymazání záznamu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                DataAccess db = new DataAccess();

                db.DeleteLabel(crudLID.Text);

                MessageBox.Show("Záznam vymazán");

                this.Close();

            }

        }

        private void empCombo_DropDown(object sender, EventArgs e)
        {

        }

        private void subCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            crudLSubjectCode.Text = subCombo.Text;

            crudLSubID.Text = subCombo.SelectedValue.ToString();

            string comboValue = this.subCombo.Text;

            


        }

        private void groupCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            crudLGroupCode.Text = groupCombo.Text;

            
            crudLGroupID.Text = groupCombo.SelectedValue.ToString();
        }

        private void crudLempFullName_TextChanged(object sender, EventArgs e)
        {
            this.crudLLabelControlName.Text = this.empCombo.Text + ' '
                + this.subCombo.Text + ' '
                + this.groupCombo.Text;
        }

        private void crudLSubjectCode_TextChanged(object sender, EventArgs e)
        {
            this.crudLLabelControlName.Text = this.empCombo.Text + ' '
                + this.subCombo.Text + ' '
                + this.groupCombo.Text;
              
            this.numericLHL.Visible = true;
            this.numericLHS.Visible = true;
            this.numericLHE.Visible = true;

            this.crudLHL.Visible = true;
            this.crudLHS.Visible = true;
            this.crudLHE.Visible = true;

            this.crudLHLLeft.Visible = true;
            this.crudLHSLeft.Visible = true;
            this.crudLHELeft.Visible = true;

            //MessageBox.Show(this.numericLHL.Text.ToString());
          
            /*
            this.numericLHL.Maximum = Convert.ToDecimal(this.crudLHL.Text);
            this.numericLHS.Maximum = Convert.ToDecimal(this.crudLHS.Text);
            this.numericLHE.Maximum = Convert.ToDecimal(this.crudLHE.Text);
            */

        }
            

        private void crudLGroupCode_TextChanged(object sender, EventArgs e)
        {
            this.crudLLabelControlName.Text = this.empCombo.Text + ' '
                + this.subCombo.Text + ' '
                + this.groupCombo.Text;
        }

        private void CRUDLabel_Load(object sender, EventArgs e)
        {
            
            empCombo.Text = this.crudLEmployeeFullName.Text?.ToString() ?? null;
            subCombo.Text = this.crudLSubjectCode.Text?.ToString() ?? null;
            groupCombo.Text = this.crudLGroupCode.Text?.ToString() ?? null;
            this.ActiveControl = this.crudLEmployeeFullName;



            if (crudLID.Text != "")
            {


                this.crudLLabelControlName.Text = this.empCombo.Text + ' '
                + this.subCombo.Text + ' '
                + this.groupCombo.Text;

                numericLHL.Value = Convert.ToDecimal(this.crudLHLAss.Text);
                numericLHS.Value = Convert.ToDecimal(this.crudLHSAss.Text);
                numericLHE.Value = Convert.ToDecimal(this.crudLHEAss.Text);

                /*
                decimal HLleft = (Convert.ToDecimal(crudLHL.Text) - (Convert.ToDecimal(crudLHLAss.Text)));
                decimal HSleft = (Convert.ToDecimal(crudLHS.Text) - (Convert.ToDecimal(crudLHSAss.Text)));
                decimal HEleft = (Convert.ToDecimal(crudLHE.Text) - (Convert.ToDecimal(crudLHEAss.Text)));
                
                

                this.crudLHLLeft.Text = Convert.ToString(HLleft);
                this.crudLHSLeft.Text = Convert.ToString(HSleft);
                this.crudLHELeft.Text = Convert.ToString(HEleft);
                */
            }

            else

            {
                this.crudLLabelControlName.Text = null;
                

               
               
            }

            if (subCombo.Text == "")

            {
                //MessageBox.Show("nejsou hodiny");

                this.numericLHL.Visible = false;
                this.numericLHS.Visible = false;
                this.numericLHE.Visible = false;

                this.crudLHL.Visible = false;
                this.crudLHS.Visible = false;
                this.crudLHE.Visible = false;

                this.crudLHLLeft.Visible = false;
                this.crudLHSLeft.Visible = false;
                this.crudLHELeft.Visible = false;


            }

/*
            if (subCombo.Text != "")
            {
                this.numericLHL.Maximum = Convert.ToDecimal(this.crudLHL.Text);
                this.numericLHS.Maximum = Convert.ToDecimal(this.crudLHS.Text);
                this.numericLHE.Maximum = Convert.ToDecimal(this.crudLHE.Text);
            }
               
*/


            ///crudLHLLeft.Text = (Convert.ToDecimal(crudLHL) - (Convert.ToDecimal(crudLHLAss))).ToString();

            //crudLHL.Text = subCombo.SelectedValue("SubjectCode").ToString();

            //crudLHL.DataBindings.Add(subCombo.SelectedValue.ToString(), "", "IDSubject"); 

            //crudLHL.Text = (subCombo.SelectedIndex + 1).ToString();

            //TextBox1.DataBindings.Add(New Binding(Text, ds.Tables(0), "OtherField"))

        }

        private void subCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            crudLHL.Text = subHelpGrid.CurrentRow.Cells[7].Value?.ToString() ?? null;
            crudLHS.Text = subHelpGrid.CurrentRow.Cells[8].Value?.ToString() ?? null;
            crudLHE.Text = subHelpGrid.CurrentRow.Cells[9].Value?.ToString() ?? null;
            crudLSem.Text = subHelpGrid.CurrentRow.Cells[3].Value?.ToString() ?? null;
            crudLLang.Text = subHelpGrid.CurrentRow.Cells[12].Value?.ToString() ?? null;
            crudLFinal.Text = subHelpGrid.CurrentRow.Cells[10].Value?.ToString() ?? null;

            this.numericLHL.Maximum = Convert.ToDecimal(this.crudLHL.Text);
            this.numericLHS.Maximum = Convert.ToDecimal(this.crudLHS.Text);
            this.numericLHE.Maximum = Convert.ToDecimal(this.crudLHE.Text);

            numericLHL.Value = 0;
            numericLHS.Value = 0;
            numericLHE.Value = 0;

            crudLHLLeft.Text = "0,0";
            crudLHSLeft.Text = "0,0";
            crudLHELeft.Text = "0,0";
        }

        private void crudLFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericLHL_ValueChanged(object sender, EventArgs e)
        {
               
                
                decimal HLleft = (Convert.ToDecimal(crudLHL.Text) - (numericLHL.Value));
                this.crudLHLLeft.Text = Convert.ToString(HLleft);

                crudLHLAss.Text = Convert.ToString(numericLHL.Value);
                
           

        }

        private void numericLHS_ValueChanged(object sender, EventArgs e)
        {
            decimal HSleft = (Convert.ToDecimal(crudLHS.Text) - (numericLHS.Value));
            

            this.crudLHSLeft.Text = Convert.ToString(HSleft);

            crudLHSAss.Text = Convert.ToString(numericLHS.Value);
        }

        private void numericLHE_ValueChanged(object sender, EventArgs e)
        {
            
            decimal HEleft = (Convert.ToDecimal(crudLHE.Text) - (numericLHE.Value));

           
            this.crudLHELeft.Text = Convert.ToString(HEleft);

            crudLHEAss.Text = Convert.ToString(numericLHE.Value);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void crudLMail_Click(object sender, EventArgs e)
        {

            MailSender createMail = new MailSender();

            createMail.senderMailAddress.Text = this.mailAddress.Text;
            createMail.senderLabelCode.Text = this.crudLLabelControlName.Text;
            createMail.senderContent.Text = 
                "Kód štítku: " + this.crudLLabelControlName.Text + Environment.NewLine + Environment.NewLine +
                "Jméno učitele: " + this.crudLEmployeeFullName.Text + Environment.NewLine + Environment.NewLine +
                "Počet hodin: " + this.crudLHLAss.Text + Environment.NewLine + Environment.NewLine +
                "Zakončení předmětu: " + this.crudLFinal.Text;






                ;
            createMail.ShowDialog();
        }
    }
}
