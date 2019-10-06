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
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rushInput = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.WrongWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.depthInput = new System.Windows.Forms.TextBox();
            this.WrongDepth = new System.Windows.Forms.ErrorProvider(this.components);
            this.drawersInput = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.materialInput = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.WrongWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WrongDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Location = new System.Drawing.Point(27, 294);
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
            this.label1.Location = new System.Drawing.Point(24, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Width (Max 15ft):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Depth (Max 7ft):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Drawers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rush Order: ";
            // 
            // rushInput
            // 
            this.rushInput.FormattingEnabled = true;
            this.rushInput.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.rushInput.Location = new System.Drawing.Point(143, 237);
            this.rushInput.Name = "rushInput";
            this.rushInput.Size = new System.Drawing.Size(146, 21);
            this.rushInput.TabIndex = 10;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(214, 294);
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
            this.widthInput.Location = new System.Drawing.Point(143, 89);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(146, 20);
            this.widthInput.TabIndex = 15;
            this.widthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthInput.Validating += new System.ComponentModel.CancelEventHandler(this.widthInput_Validating);
            // 
            // WrongWidth
            // 
            this.WrongWidth.ContainerControl = this;
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(143, 125);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(146, 20);
            this.depthInput.TabIndex = 18;
            this.depthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.depthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthInput_KeyPress);
            // 
            // WrongDepth
            // 
            this.WrongDepth.ContainerControl = this;
            // 
            // drawersInput
            // 
            this.drawersInput.FormattingEnabled = true;
            this.drawersInput.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawersInput.Location = new System.Drawing.Point(143, 165);
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(146, 21);
            this.drawersInput.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Enter your name: ";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(143, 46);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(146, 20);
            this.nameInput.TabIndex = 21;
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Select Material: ";
            // 
            // materialInput
            // 
            this.materialInput.FormattingEnabled = true;
            this.materialInput.Items.AddRange(new object[] {
            "Oak",
            "Rosewood",
            "Laminate",
            "Veneer",
            "Pine"});
            this.materialInput.Location = new System.Drawing.Point(143, 201);
            this.materialInput.Name = "materialInput";
            this.materialInput.Size = new System.Drawing.Size(146, 21);
            this.materialInput.TabIndex = 23;
            // 
            // AddQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 349);
            this.Controls.Add(this.materialInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.rushInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenu);
            this.Name = "AddQuotes";
            this.Text = "AddQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.WrongWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WrongDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rushInput;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.ErrorProvider WrongWidth;
        private System.Windows.Forms.TextBox depthInput;
        private System.Windows.Forms.ErrorProvider WrongDepth;
        private System.Windows.Forms.ComboBox drawersInput;
        private System.Windows.Forms.ComboBox materialInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label5;
    }
}