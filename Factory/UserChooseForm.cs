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
    public partial class UserChooseForm : Form
    {
        public UserChooseForm()
        {
            InitializeComponent();
        }

        private void ManagerButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(Role.Manager);
            main.Show();
        }

        private void WorkerButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(Role.Worker);
            main.Show();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm(Role.Clinet);
            main.Show();
        }
    }
}
