namespace Factory
{
    partial class OrderForm
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
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label idClientLabel;
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.OkOrderButton = new System.Windows.Forms.Button();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxTypeOfFurniture = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            subjectLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            idClientLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new System.Drawing.Point(14, 27);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(46, 13);
            subjectLabel.TabIndex = 3;
            subjectLabel.Text = "Subject:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(14, 80);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "Price:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(14, 106);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "Status:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(14, 132);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Date:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(14, 158);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(54, 13);
            commentLabel.TabIndex = 11;
            commentLabel.Text = "Comment:";
            // 
            // idClientLabel
            // 
            idClientLabel.AutoSize = true;
            idClientLabel.Location = new System.Drawing.Point(14, 184);
            idClientLabel.Name = "idClientLabel";
            idClientLabel.Size = new System.Drawing.Size(48, 13);
            idClientLabel.TabIndex = 13;
            idClientLabel.Text = "Id Client:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(74, 77);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 6;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(74, 103);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 8;
            this.statusTextBox.Text = "Ожидаеться";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(74, 155);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(100, 20);
            this.commentTextBox.TabIndex = 12;
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.Location = new System.Drawing.Point(74, 181);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClientTextBox.TabIndex = 14;
            // 
            // OkOrderButton
            // 
            this.OkOrderButton.Location = new System.Drawing.Point(99, 207);
            this.OkOrderButton.Name = "OkOrderButton";
            this.OkOrderButton.Size = new System.Drawing.Size(75, 23);
            this.OkOrderButton.TabIndex = 15;
            this.OkOrderButton.Text = "Ok";
            this.OkOrderButton.UseVisualStyleBackColor = true;
            this.OkOrderButton.Click += new System.EventHandler(this.OkOrderButton_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(74, 24);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(100, 20);
            this.subjectTextBox.TabIndex = 4;
            // 
            // comboBoxTypeOfFurniture
            // 
            this.comboBoxTypeOfFurniture.FormattingEnabled = true;
            this.comboBoxTypeOfFurniture.Location = new System.Drawing.Point(74, 50);
            this.comboBoxTypeOfFurniture.Name = "comboBoxTypeOfFurniture";
            this.comboBoxTypeOfFurniture.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTypeOfFurniture.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 284);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxTypeOfFurniture);
            this.Controls.Add(this.OkOrderButton);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(idClientLabel);
            this.Controls.Add(this.idClientTextBox);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.Button OkOrderButton;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.ComboBox comboBoxTypeOfFurniture;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}