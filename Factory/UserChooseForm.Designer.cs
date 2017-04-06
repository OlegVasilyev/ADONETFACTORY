namespace Factory
{
    partial class UserChooseForm
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
            this.ManagerButton = new System.Windows.Forms.Button();
            this.WorkerButton = new System.Windows.Forms.Button();
            this.ClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManagerButton
            // 
            this.ManagerButton.Location = new System.Drawing.Point(12, 52);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(75, 23);
            this.ManagerButton.TabIndex = 0;
            this.ManagerButton.Text = "Manager";
            this.ManagerButton.UseVisualStyleBackColor = true;
            this.ManagerButton.Click += new System.EventHandler(this.ManagerButton_Click);
            // 
            // WorkerButton
            // 
            this.WorkerButton.Location = new System.Drawing.Point(102, 52);
            this.WorkerButton.Name = "WorkerButton";
            this.WorkerButton.Size = new System.Drawing.Size(75, 23);
            this.WorkerButton.TabIndex = 1;
            this.WorkerButton.Text = "Worker";
            this.WorkerButton.UseVisualStyleBackColor = true;
            this.WorkerButton.Click += new System.EventHandler(this.WorkerButton_Click);
            // 
            // ClientButton
            // 
            this.ClientButton.Location = new System.Drawing.Point(197, 52);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(75, 23);
            this.ClientButton.TabIndex = 2;
            this.ClientButton.Text = "Client";
            this.ClientButton.UseVisualStyleBackColor = true;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // UserChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 262);
            this.Controls.Add(this.ClientButton);
            this.Controls.Add(this.WorkerButton);
            this.Controls.Add(this.ManagerButton);
            this.Name = "UserChooseForm";
            this.Text = "UserChooseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManagerButton;
        private System.Windows.Forms.Button WorkerButton;
        private System.Windows.Forms.Button ClientButton;
    }
}