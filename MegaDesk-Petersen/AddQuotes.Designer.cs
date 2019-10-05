namespace MegaDesk_Petersen
{
    partial class AddQuotes
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
            this.mainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.drawersInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(25, 402);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainMenu.Size = new System.Drawing.Size(75, 23);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "Go Back";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Width (ft):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Depth (ft):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter # of Drawers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rush Order: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.comboBox1.Location = new System.Drawing.Point(141, 289);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(212, 402);
            this.Submit.Name = "Submit";
            this.Submit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 14;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.SubmitOrder_Click);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(141, 80);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(146, 20);
            this.widthInput.TabIndex = 15;
            this.widthInput.Text = "Enter Number (Max 15ft.)";
            this.widthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(141, 147);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(146, 20);
            this.depthInput.TabIndex = 16;
            this.depthInput.Text = "Enter Number (Max 7ft.)";
            this.depthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drawersInput
            // 
            this.drawersInput.Location = new System.Drawing.Point(141, 217);
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.drawersInput.Size = new System.Drawing.Size(146, 20);
            this.drawersInput.TabIndex = 17;
            this.drawersInput.Text = "Enter Number (Max 7)";
            this.drawersInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenu);
            this.Name = "AddQuotes";
            this.Text = "AddQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.TextBox drawersInput;
    }
}