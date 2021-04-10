using System;
using System.Windows.Forms;

namespace SecretaryAgenda
{
    public partial class CRUDEmployee : Form
    {
        
    public CRUDEmployee()
        {
            InitializeComponent();      
        }

        //public bool Closeform { get; set; }

        private void CRUDEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void crudEIsDocChckToggle(object sender, EventArgs e)
        {
            
        }

        private void crudESave_Click(object sender, EventArgs e)
        {
            //if (this.crudEFirstName.TextLength == 0)
            bool bfn = string.IsNullOrWhiteSpace(this.crudEFirstName.Text);
            bool bln = string.IsNullOrWhiteSpace(this.crudELastName.Text);
            bool bob = string.IsNullOrWhiteSpace(this.crudEObligation.Text);
           
            if (bfn == true || bln == true)
            {
                MessageBox.Show("Doplňte jnémo a příjmení zaměstnance");
            }

            else if (bob == true)
            {
                MessageBox.Show("Doplňte úvazek zaměstnance");
            }
            else if ( Convert.ToDouble (this.crudEObligation.Text) > 1 )
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
            if (MessageBox.Show("Vymazání záznamu", "Opravdu chcete vymazat záznam?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
  
            DataAccess db = new DataAccess();

            db.DeleteEmployee(crudEID.Text);
           
            MessageBox.Show("Záznam vymazán");
            
            this.Close();

            }

        }
    }
}
