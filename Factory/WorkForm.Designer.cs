namespace Factory
{
    partial class WorkForm
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
            this.buttonSendFutnityre = new System.Windows.Forms.Button();
            this.CreateFurnityreButton = new System.Windows.Forms.Button();
            this.SendFurniture = new System.Windows.Forms.Button();
            this.buttonBuyMaterial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSendFutnityre
            // 
            this.buttonSendFutnityre.Location = new System.Drawing.Point(12, 12);
            this.buttonSendFutnityre.Name = "buttonSendFutnityre";
            this.buttonSendFutnityre.Size = new System.Drawing.Size(120, 23);
            this.buttonSendFutnityre.TabIndex = 3;
            this.buttonSendFutnityre.Text = "Нанять рабочего";
            this.buttonSendFutnityre.UseVisualStyleBackColor = true;
            this.buttonSendFutnityre.Click += new System.EventHandler(this.FindWorker_Click);
            // 
            // CreateFurnityreButton
            // 
            this.CreateFurnityreButton.Location = new System.Drawing.Point(12, 70);
            this.CreateFurnityreButton.Name = "CreateFurnityreButton";
            this.CreateFurnityreButton.Size = new System.Drawing.Size(120, 23);
            this.CreateFurnityreButton.TabIndex = 5;
            this.CreateFurnityreButton.Text = "Создать товар";
            this.CreateFurnityreButton.UseVisualStyleBackColor = true;
            this.CreateFurnityreButton.Click += new System.EventHandler(this.CreateFurnityreButton_Click);
            // 
            // SendFurniture
            // 
            this.SendFurniture.Location = new System.Drawing.Point(12, 99);
            this.SendFurniture.Name = "SendFurniture";
            this.SendFurniture.Size = new System.Drawing.Size(120, 23);
            this.SendFurniture.TabIndex = 6;
            this.SendFurniture.Text = "Оправить товар";
            this.SendFurniture.UseVisualStyleBackColor = true;
            this.SendFurniture.Click += new System.EventHandler(this.SendFurniture_Click);
            // 
            // buttonBuyMaterial
            // 
            this.buttonBuyMaterial.Location = new System.Drawing.Point(12, 41);
            this.buttonBuyMaterial.Name = "buttonBuyMaterial";
            this.buttonBuyMaterial.Size = new System.Drawing.Size(120, 23);
            this.buttonBuyMaterial.TabIndex = 7;
            this.buttonBuyMaterial.Text = "Закупить материал";
            this.buttonBuyMaterial.UseVisualStyleBackColor = true;
            this.buttonBuyMaterial.Click += new System.EventHandler(this.buttonBuyMaterial_Click);
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 130);
            this.Controls.Add(this.buttonBuyMaterial);
            this.Controls.Add(this.SendFurniture);
            this.Controls.Add(this.CreateFurnityreButton);
            this.Controls.Add(this.buttonSendFutnityre);
            this.Name = "WorkForm";
            this.Text = "WorkForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSendFutnityre;
        private System.Windows.Forms.Button FindWorker;
        private System.Windows.Forms.Button CreateFurnityreButton;
        private System.Windows.Forms.Button SendFurniture;
        private System.Windows.Forms.Button buttonBuyMaterial;
    }
}