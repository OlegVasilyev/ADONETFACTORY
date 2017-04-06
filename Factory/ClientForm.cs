using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class ClientForm : Form
    {
        DAL dal = new DAL();
        public ClientForm()
        {
            InitializeComponent();

        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            if (this.dal.AddClient(this.firstNameTextBox.Text.Trim(), this.secondNameTextBox.Text.Trim(), this.numberPhoneTextBox.Text.Trim(), adressTextBox.Text.Trim()))
            {
                base.DialogResult = DialogResult.OK;
            }
            else
            {
                base.DialogResult = DialogResult.No;
            }
        }
    }
}
