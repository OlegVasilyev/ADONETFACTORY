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
    public partial class PayForm : Form
    {
        decimal price;
        int id;
        DAL dal;
        public PayForm(int id, decimal price)
        {
            InitializeComponent();
            this.price = price;
            this.id = id;
            PriceLabel.Text += price.ToString();
            dal = new DAL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dal.EditStatusOrder(id, "Оплачено!");
            this.Close();
        }
    }
}
