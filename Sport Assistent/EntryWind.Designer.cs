namespace Sport_Assistent
{
    partial class EntryWind
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.entryLabel = new System.Windows.Forms.Label();
            this.accesRestorationButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.entryLabel);
            this.mainPanel.Controls.Add(this.accesRestorationButton);
            this.mainPanel.Controls.Add(this.emailTextBox);
            this.mainPanel.Controls.Add(this.registrationButton);
            this.mainPanel.Controls.Add(this.passwordTextBox);
            this.mainPanel.Controls.Add(this.continueButton);
            this.mainPanel.Controls.Add(this.passwordLabel);
            this.mainPanel.Controls.Add(this.emailLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1092, 599);
            this.mainPanel.TabIndex = 8;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // entryLabel
            // 
            this.entryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entryLabel.AutoSize = true;
            this.entryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryLabel.Location = new System.Drawing.Point(185, 58);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(744, 32);
            this.entryLabel.TabIndex = 0;
            this.entryLabel.Text = "Чтобы войти в аккаунт, введите его email и пароль.";
            // 
            // accesRestorationButton
            // 
            this.accesRestorationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accesRestorationButton.BackColor = System.Drawing.Color.Transparent;
            this.accesRestorationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.accesRestorationButton.FlatAppearance.BorderSize = 0;
            this.accesRestorationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.accesRestorationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.accesRestorationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accesRestorationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accesRestorationButton.ForeColor = System.Drawing.Color.Teal;
            this.accesRestorationButton.Location = new System.Drawing.Point(465, 480);
            this.accesRestorationButton.Margin = new System.Windows.Forms.Padding(4);
            this.accesRestorationButton.Name = "accesRestorationButton";
            this.accesRestorationButton.Size = new System.Drawing.Size(209, 32);
            this.accesRestorationButton.TabIndex = 7;
            this.accesRestorationButton.Text = "Не можете войти?";
            this.accesRestorationButton.UseVisualStyleBackColor = false;
            this.accesRestorationButton.Click += new System.EventHandler(this.accesRestorationButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(395, 197);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(387, 30);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // registrationButton
            // 
            this.registrationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrationButton.BackColor = System.Drawing.Color.Transparent;
            this.registrationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registrationButton.FlatAppearance.BorderSize = 0;
            this.registrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.registrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.ForeColor = System.Drawing.Color.Teal;
            this.registrationButton.Location = new System.Drawing.Point(465, 440);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(4);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(209, 32);
            this.registrationButton.TabIndex = 6;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(395, 267);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(387, 30);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
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
            this.continueButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.continueButton.Location = new System.Drawing.Point(453, 382);
            this.continueButton.Margin = new System.Windows.Forms.Padding(4);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(231, 50);
            this.continueButton.TabIndex = 5;
            this.continueButton.Text = "Войти";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(287, 268);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(102, 29);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль:";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(309, 197);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(80, 29);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email:";
            this.emailLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // EntryWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1092, 599);
            this.Controls.Add(this.mainPanel);
            this.Name = "EntryWind";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EntryWind_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label entryLabel;
        private System.Windows.Forms.Button accesRestorationButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.Panel mainPanel;
    }
}