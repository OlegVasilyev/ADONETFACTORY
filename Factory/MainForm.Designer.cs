namespace Factory
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridCLient = new System.Windows.Forms.DataGridView();
            this.contextMenuAddOrder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.contextMenuForJob = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.взятьРаботуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCLinetButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.NextSearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxColumn = new System.Windows.Forms.ComboBox();
            this.CheckInDataBase = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCLient)).BeginInit();
            this.contextMenuAddOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.contextMenuForJob.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCLient
            // 
            this.dataGridCLient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCLient.ContextMenuStrip = this.contextMenuAddOrder;
            this.dataGridCLient.Location = new System.Drawing.Point(12, 112);
            this.dataGridCLient.Name = "dataGridCLient";
            this.dataGridCLient.Size = new System.Drawing.Size(489, 187);
            this.dataGridCLient.TabIndex = 0;
            this.dataGridCLient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCLient_CellClick);
            this.dataGridCLient.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridClient_CellMouseDoubleClick);
            // 
            // contextMenuAddOrder
            // 
            this.contextMenuAddOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаказToolStripMenuItem});
            this.contextMenuAddOrder.Name = "contextMenuAddOrder";
            this.contextMenuAddOrder.Size = new System.Drawing.Size(158, 26);
            // 
            // добавитьЗаказToolStripMenuItem
            // 
            this.добавитьЗаказToolStripMenuItem.Name = "добавитьЗаказToolStripMenuItem";
            this.добавитьЗаказToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.добавитьЗаказToolStripMenuItem.Text = "Добавить заказ";
            this.добавитьЗаказToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаказToolStripMenuItem_Click);
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.ContextMenuStrip = this.contextMenuForJob;
            this.dataGridOrder.Location = new System.Drawing.Point(12, 314);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.Size = new System.Drawing.Size(695, 187);
            this.dataGridOrder.TabIndex = 1;
            this.dataGridOrder.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridOrder_CellMouseDoubleClick);
            // 
            // contextMenuForJob
            // 
            this.contextMenuForJob.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.взятьРаботуToolStripMenuItem});
            this.contextMenuForJob.Name = "contextMenuForJob";
            this.contextMenuForJob.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuForJob.Size = new System.Drawing.Size(145, 26);
            // 
            // взятьРаботуToolStripMenuItem
            // 
            this.взятьРаботуToolStripMenuItem.Name = "взятьРаботуToolStripMenuItem";
            this.взятьРаботуToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.взятьРаботуToolStripMenuItem.Text = "Взять работу";
            this.взятьРаботуToolStripMenuItem.Click += new System.EventHandler(this.взятьРаботуToolStripMenuItem_Click);
            // 
            // AddCLinetButton
            // 
            this.AddCLinetButton.Location = new System.Drawing.Point(507, 112);
            this.AddCLinetButton.Name = "AddCLinetButton";
            this.AddCLinetButton.Size = new System.Drawing.Size(75, 23);
            this.AddCLinetButton.TabIndex = 2;
            this.AddCLinetButton.Text = "Add Client";
            this.AddCLinetButton.UseVisualStyleBackColor = true;
            this.AddCLinetButton.Click += new System.EventHandler(this.AddCLinetButton_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.NextSearchButton);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.comboBoxColumn);
            this.groupBox7.Controls.Add(this.CheckInDataBase);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.searchText);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.comboBoxTable);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(643, 94);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Поиск";
            // 
            // NextSearchButton
            // 
            this.NextSearchButton.Enabled = false;
            this.NextSearchButton.Location = new System.Drawing.Point(565, 27);
            this.NextSearchButton.Name = "NextSearchButton";
            this.NextSearchButton.Size = new System.Drawing.Size(71, 22);
            this.NextSearchButton.TabIndex = 10;
            this.NextSearchButton.Text = "Next";
            this.NextSearchButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "столбец:";
            // 
            // comboBoxColumn
            // 
            this.comboBoxColumn.FormattingEnabled = true;
            this.comboBoxColumn.Location = new System.Drawing.Point(218, 28);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Size = new System.Drawing.Size(98, 21);
            this.comboBoxColumn.TabIndex = 8;
            // 
            // CheckInDataBase
            // 
            this.CheckInDataBase.AutoSize = true;
            this.CheckInDataBase.Location = new System.Drawing.Point(468, 30);
            this.CheckInDataBase.Name = "CheckInDataBase";
            this.CheckInDataBase.Size = new System.Drawing.Size(91, 17);
            this.CheckInDataBase.TabIndex = 7;
            this.CheckInDataBase.Text = "Искать в БД";
            this.CheckInDataBase.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "текст:";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(366, 29);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(96, 20);
            this.searchText.TabIndex = 5;
            this.searchText.TextChanged += new System.EventHandler(this.seachText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица:";
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Items.AddRange(new object[] {
            "Client",
            "Order"});
            this.comboBoxTable.Location = new System.Drawing.Point(55, 28);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(98, 21);
            this.comboBoxTable.TabIndex = 0;
            this.comboBoxTable.TextChanged += new System.EventHandler(this.comboBoxTable_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 544);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.AddCLinetButton);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.dataGridCLient);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCLient)).EndInit();
            this.contextMenuAddOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.contextMenuForJob.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCLient;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuAddOrder;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаказToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuForJob;
        private System.Windows.Forms.ToolStripMenuItem взятьРаботуToolStripMenuItem;
        private System.Windows.Forms.Button AddCLinetButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button NextSearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxColumn;
        private System.Windows.Forms.CheckBox CheckInDataBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTable;
    }
}