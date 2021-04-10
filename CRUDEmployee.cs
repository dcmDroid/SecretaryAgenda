using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecretaryAgenda
{
    public partial class CRUDEmployee : Form
    {
        List<Employee> People = new List<Employee>();


        public CRUDEmployee()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();

            People = db.FreeSearch_Employee(crudEFullName.Text);

            UpdateBinding();
        }

        private void UpdateBinding()
        {

            empHelpGrid.DataSource = People;

        }
        //public bool Closeform { get; set; }

        private void CRUDEmployee_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(crudEID.ToString());
        }

        private void crudEIsDocChckToggle(object sender, EventArgs e)
        {

        }

        private void crudESave_Click(object sender, EventArgs e)
        {
            this.crudEFullName.Text = this.crudEFirstName.Text + ' ' + this.crudELastName.Text;

            //if (this.crudEFirstName.TextLength == 0)
            bool bfn = string.IsNullOrWhiteSpace(this.crudEFirstName.Text);
            bool bln = string.IsNullOrWhiteSpace(this.crudELastName.Text);
            bool bob = string.IsNullOrWhiteSpace(this.crudEObligation.Text);
            bool duplicate = false;


            for (int i = 0; i < empHelpGrid.Rows.Count; i++)
            {
                if (crudEFullName.Text == empHelpGrid.Rows[i].Cells[1].Value.ToString() + ' ' +
                    empHelpGrid.Rows[i].Cells[2].Value.ToString() && this.crudEID.Text == "")

                {
                    duplicate = true;
                    MessageBox.Show("Zaměstnanec tohoto jména již existuje");
                    break;
                }
            }

            if (!duplicate)
            {
                if (bfn == true || bln == true)
                {
                    MessageBox.Show("Doplňte jnémo a příjmení zaměstnance");
                }
                else if (bob == true)
                {
                    MessageBox.Show("Doplňte úvazek zaměstnance");
                }
                else if (Convert.ToDouble(this.crudEObligation.Text) > 1)
                {
                    MessageBox.Show("Maximální hodnota úvazku je 1");
                }
                else
                {
                    DataAccess db = new DataAccess();

                    db.ModifyEmployee(crudEFirstName.Text, crudELastName.Text, crudEEmail.Text, crudECell.Text, crudEPhone.Text, Convert.ToDecimal(crudEObligation.Text), crudEIsDocChck.Checked, crudEID.Text);

                    MessageBox.Show("Záznam uložen");
                    this.Close();
                }
            }    
              
        }    
                            

            
            /*
            if (bfn == true || bln == true)
                              
                    {
                        MessageBox.Show("Doplňte jnémo a příjmení zaměstnance");
                    }

                else if (bob == true)
                    {
                        MessageBox.Show("Doplňte úvazek zaměstnance");
                    }
                else if (Convert.ToDouble(this.crudEObligation.Text) > 1)
                    {
                        MessageBox.Show("Maximální hodnota úvazku je 1");
                    }

                else
                    { 
                        DataAccess db = new DataAccess();

                        db.ModifyEmployee(crudEFirstName.Text, crudELastName.Text, crudEEmail.Text, crudECell.Text, crudEPhone.Text, Convert.ToDecimal(crudEObligation.Text), crudEIsDocChck.Checked, crudEID.Text);

                        MessageBox.Show("Záznam uložen");
                        this.Close();
                    }               
                   */
        

        private void crudEIsDoc_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("doktor změněn");
        }

        private void crudEObligation_TextChanged(object sender, EventArgs e)
        {

        }

        private void crudEObligation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void crudEObligation_Leave(object sender, EventArgs e)
        {

        }

        private void crudEDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Opravdu chcete vymazat záznam?", "Vymazání záznamu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                DataAccess db = new DataAccess();

                db.DeleteEmployee(crudEID.Text);

                MessageBox.Show("Záznam vymazán");

                this.Close();

            }

        }

        private void CRUDEmployee_Load_1(object sender, EventArgs e)
        {

        }
    }
}
