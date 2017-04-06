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
    public partial class OrderForm : Form
    {
        DAL dal = new DAL();
        public OrderForm(object id)
        {
            InitializeComponent();
            idClientTextBox.Text = id.ToString();
            comboBoxTypeOfFurniture.DataSource = Enum.GetValues(typeof(TypeFurniture));
            comboBoxTypeOfFurniture.SelectedItem = TypeFurniture.Wood;
        }
        private void OkOrderButton_Click(object sender, EventArgs e)
        {
            if (this.dal.AddOrder(this.subjectTextBox.Text.Trim(), this.comboBoxTypeOfFurniture.Text.Trim(), this.priceTextBox.Text.Trim(), this.statusTextBox.Text.Trim(), this.dateTimePicker1.Value.ToString(), this.commentTextBox.Text.Trim(), this.idClientTextBox.Text.Trim()))
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
