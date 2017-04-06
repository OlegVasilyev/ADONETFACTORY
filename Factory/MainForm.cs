using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class MainForm : Form
    {
        DAL dal = new DAL();
        List<DataGridViewRow> listDataGrid;
        public MainForm(Role role)
        {
            InitializeComponent();

            if (role == Role.Clinet)
            {
                dataGridOrder.ContextMenuStrip.Enabled = false;
                AddCLinetButton.Hide();
                dataGridCLient.ContextMenuStrip.Enabled = false;
            }
            if (role == Role.Worker)
            {
                AddCLinetButton.Hide();
                dataGridCLient.ContextMenuStrip.Enabled = false;
            }
            if (role == Role.Manager)
            {
                dataGridOrder.ContextMenuStrip.Enabled = false;
            }
            dataGridCLient.DataSource = dal.GetClient();
            dataGridOrder.DataSource = dal.GetOrder(1);
        }

        private void dataGridCLient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridOrder.DataSource = dal.GetOrder((int)this.dataGridCLient.CurrentRow.Cells["Id"].Value);
        }

        private void добавитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderform = new OrderForm((int)this.dataGridCLient.CurrentRow.Cells["Id"].Value);
            if (orderform.ShowDialog() == DialogResult.OK)
            {
                dataGridOrder.DataSource = dal.GetOrder((int)this.dataGridCLient.CurrentRow.Cells["Id"].Value);
                MessageBox.Show("Заказ внесен в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Заказ НЕ внесен в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void взятьРаботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dal.EditStatusOrder((int)this.dataGridCLient.CurrentRow.Cells["Id"].Value))
            {
                dataGridOrder.DataSource = dal.GetOrder((int)this.dataGridCLient.CurrentRow.Cells["Id"].Value);
                WorkForm workform = new WorkForm((int)this.dataGridOrder.CurrentRow.Cells["Id"].Value, this.dataGridOrder.CurrentRow.Cells["Type"].Value.ToString());
                workform.ShowDialog();
                dataGridOrder.DataSource = dal.GetOrder((int)this.dataGridCLient.CurrentRow.Cells["Id"].Value);

            }
        }

        private void AddCLinetButton_Click(object sender, EventArgs e)
        {
            ClientForm clientform = new ClientForm();
            if (clientform.ShowDialog() == DialogResult.OK)
            {
                dataGridCLient.DataSource = dal.GetClient();
                MessageBox.Show("Клиент внесен в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Клиент НЕ внесен в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void seachText_TextChanged(object sender, EventArgs e)
        {
           
            if (this.searchText.Text != "")
            {
                try
                {
                    foreach (DataGridViewRow row in this.listDataGrid)
                    {
                        if (this.comboBoxTable.Text == NameTable.Client.ToString())
                        {
                            this.dataGridCLient.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                        if (this.comboBoxTable.Text == NameTable.Order.ToString())
                        {
                            this.dataGridOrder.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                }
                catch
                {
                }
                this.listDataGrid = new List<DataGridViewRow>();

                if (this.CheckInDataBase.Checked && (this.comboBoxTable.Text == NameTable.Client.ToString()))
                {
                    try
                    {
                        ArrayList list = this.dal.SearchClient(this.searchText.Text.Trim());
                        if ((list == null) && (list.Count <= 0))
                        {
                            this.dataGridCLient.DataSource = list;
                        }
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        foreach (DataGridViewRow row2 in dataGridCLient.Rows)
                        {
                            if (row2.Cells[this.comboBoxColumn.Text.Trim()].FormattedValue.ToString().Contains(this.searchText.Text.Trim()))
                            {
                                this.listDataGrid.Add(row2);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
                if (this.CheckInDataBase.Checked && (this.comboBoxTable.Text == NameTable.Order.ToString()))
                {
                    try
                    {
                        ArrayList list = this.dal.SearchOrder(this.searchText.Text.Trim());
                        if ((list == null) && (list.Count <= 0))
                        {
                            this.dataGridCLient.DataSource = list;
                        }
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        foreach (DataGridViewRow row2 in dataGridOrder.Rows)
                        {
                            if (row2.Cells[this.comboBoxColumn.Text.Trim()].FormattedValue.ToString().Contains(this.searchText.Text.Trim()))
                            {
                                this.listDataGrid.Add(row2);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }
            if (this.listDataGrid.Count > 0)
            {
                foreach (DataGridViewRow row8 in this.listDataGrid)
                {
                    if (this.comboBoxTable.Text == NameTable.Client.ToString())
                    {
                        this.dataGridCLient.Rows[row8.Index].DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (this.comboBoxTable.Text == NameTable.Order.ToString())
                    {
                        this.dataGridOrder.Rows[row8.Index].DefaultCellStyle.BackColor = Color.Green;
                    }
                    this.NextSearchButton.Enabled = true;
                }
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in this.listDataGrid)
                    {
                        if (this.comboBoxTable.Text == NameTable.Client.ToString())
                        {
                            this.dataGridCLient.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                        if (this.comboBoxTable.Text == NameTable.Client.ToString())
                        {
                            this.dataGridOrder.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                        }
                    }

                }
                catch { }
            }

        }

        private void comboBoxTable_TextChanged(object sender, EventArgs e)
        {
            comboBoxColumn.Items.Clear();
            if (comboBoxTable.Text == NameTable.Order.ToString())
            {
                foreach (DataGridViewColumn column in dataGridOrder.Columns)
                {
                    comboBoxColumn.Items.Add(column.Name);
                }
            }
            else
            {
                foreach (DataGridViewColumn column in dataGridCLient.Columns)
                {
                    comboBoxColumn.Items.Add(column.Name);
                }
            }
        }

        private void dataGridOrder_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.ColumnIndex > -1) && (e.RowIndex > -1))
            {
                this.dataGridOrder[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Aqua;
            }
        }
        private void dataGridClient_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.ColumnIndex > -1) && (e.RowIndex > -1))
            {
                this.dataGridCLient[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Aqua;
            }
        }
    }
}
