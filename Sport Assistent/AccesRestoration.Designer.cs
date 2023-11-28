namespace Sport_Assistent
{
    partial class AccesRestorationWind
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
            this.continueButton = new System.Windows.Forms.Button();
            this.inputPasswordPanel = new System.Windows.Forms.Panel();
            this.row2 = new System.Windows.Forms.Label();
            this.row1 = new System.Windows.Forms.Label();
            this.entryLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.inputPasswordPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // continueButton
            // 
            this.continueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.continueButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continueButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.continueButton.FlatAppearance.BorderSize = 2;
            this.continueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.continueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueButton.ForeColor = System.Drawing.Color.Orange;
            this.continueButton.Location = new System.Drawing.Point(482, 385);
            this.continueButton.Margin = new System.Windows.Forms.Padding(4);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(173, 50);
            this.continueButton.TabIndex = 19;
            this.continueButton.Text = "Продолжить\r\n";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // inputPasswordPanel
            // 
            this.inputPasswordPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputPasswordPanel.BackColor = System.Drawing.Color.Transparent;
            this.inputPasswordPanel.Controls.Add(this.row2);
            this.inputPasswordPanel.Controls.Add(this.row1);
            this.inputPasswordPanel.Controls.Add(this.entryLabel);
            this.inputPasswordPanel.ForeColor = System.Drawing.Color.Black;
            this.inputPasswordPanel.Location = new System.Drawing.Point(85, 96);
            this.inputPasswordPanel.Name = "inputPasswordPanel";
            this.inputPasswordPanel.Size = new System.Drawing.Size(927, 114);
            this.inputPasswordPanel.TabIndex = 18;
            // 
            // row2
            // 
            this.row2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.row2.AutoSize = true;
            this.row2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.row2.Location = new System.Drawing.Point(182, 61);
            this.row2.Name = "row2";
            this.row2.Size = new System.Drawing.Size(597, 32);
            this.row2.TabIndex = 7;
            this.row2.Text = "Для входа вам нужно ввести этот пароль";
            // 
            // row1
            // 
            this.row1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.row1.AutoSize = true;
            this.row1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.row1.Location = new System.Drawing.Point(30, 10);
            this.row1.Name = "row1";
            this.row1.Size = new System.Drawing.Size(880, 32);
            this.row1.TabIndex = 8;
            this.row1.Text = "Мы отправили письмо с паролем на вашу электронную почту";
            this.row1.Click += new System.EventHandler(this.label1_Click);
            // 
            // entryLabel
            // 
            this.entryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entryLabel.AutoSize = true;
            this.entryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryLabel.Location = new System.Drawing.Point(249, -22);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(0, 32);
            this.entryLabel.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel.Location = new System.Drawing.Point(302, 262);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(102, 29);
            this.passwordLabel.TabIndex = 16;
            this.passwordLabel.Text = "Пароль:";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordTextBox.Location = new System.Drawing.Point(410, 261);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(387, 30);
            this.passwordTextBox.TabIndex = 17;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.inputPasswordPanel);
            this.mainPanel.Controls.Add(this.continueButton);
            this.mainPanel.Controls.Add(this.passwordTextBox);
            this.mainPanel.Controls.Add(this.passwordLabel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1092, 599);
            this.mainPanel.TabIndex = 20;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // AccesRestorationWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1092, 599);
            this.Controls.Add(this.mainPanel);
            this.Name = "AccesRestorationWind";
            this.Text = "j";
            this.Load += new System.EventHandler(this.AccesRestorationWind_Load);
            this.inputPasswordPanel.ResumeLayout(false);
            this.inputPasswordPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Panel inputPasswordPanel;
        private System.Windows.Forms.Label row2;
        private System.Windows.Forms.Label row1;
        private System.Windows.Forms.Label entryLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel mainPanel;
    }
}