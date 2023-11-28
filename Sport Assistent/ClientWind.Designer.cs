namespace Sport_Assistent
{
    partial class ClientWind
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
            this.clientLabel = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.profilePage = new System.Windows.Forms.TabPage();
            this.subscriptionPage = new System.Windows.Forms.TabPage();
            this.timetablePage = new System.Windows.Forms.TabPage();
            this.notificationsPage = new System.Windows.Forms.TabPage();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.Zameni_Menia_Leha_sdelai_krasivo = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.patronymic = new System.Windows.Forms.Label();
            this.dataPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.profilePage.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientLabel
            // 
            this.clientLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLabel.Location = new System.Drawing.Point(374, 16);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(81, 24);
            this.clientLabel.TabIndex = 3;
            this.clientLabel.Text = "Клиент";
            this.clientLabel.Click += new System.EventHandler(this.trainerLabel_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataPanel.BackColor = System.Drawing.Color.Orange;
            this.dataPanel.Controls.Add(this.tabControl1);
            this.dataPanel.Location = new System.Drawing.Point(32, 42);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(758, 426);
            this.dataPanel.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.profilePage);
            this.tabControl1.Controls.Add(this.subscriptionPage);
            this.tabControl1.Controls.Add(this.timetablePage);
            this.tabControl1.Controls.Add(this.notificationsPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(18, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // profilePage
            // 
            this.profilePage.Controls.Add(this.patronymic);
            this.profilePage.Controls.Add(this.name);
            this.profilePage.Controls.Add(this.surname);
            this.profilePage.Controls.Add(this.Zameni_Menia_Leha_sdelai_krasivo);
            this.profilePage.Location = new System.Drawing.Point(4, 35);
            this.profilePage.Name = "profilePage";
            this.profilePage.Padding = new System.Windows.Forms.Padding(3);
            this.profilePage.Size = new System.Drawing.Size(713, 349);
            this.profilePage.TabIndex = 3;
            this.profilePage.Text = "Профиль";
            this.profilePage.UseVisualStyleBackColor = true;
            this.profilePage.Click += new System.EventHandler(this.profilePage_Click);
            // 
            // subscriptionPage
            // 
            this.subscriptionPage.Location = new System.Drawing.Point(4, 35);
            this.subscriptionPage.Margin = new System.Windows.Forms.Padding(2);
            this.subscriptionPage.Name = "subscriptionPage";
            this.subscriptionPage.Padding = new System.Windows.Forms.Padding(2);
            this.subscriptionPage.Size = new System.Drawing.Size(713, 349);
            this.subscriptionPage.TabIndex = 0;
            this.subscriptionPage.Text = "Абонементы";
            this.subscriptionPage.UseVisualStyleBackColor = true;
            // 
            // timetablePage
            // 
            this.timetablePage.Location = new System.Drawing.Point(4, 35);
            this.timetablePage.Margin = new System.Windows.Forms.Padding(2);
            this.timetablePage.Name = "timetablePage";
            this.timetablePage.Padding = new System.Windows.Forms.Padding(2);
            this.timetablePage.Size = new System.Drawing.Size(713, 349);
            this.timetablePage.TabIndex = 1;
            this.timetablePage.Text = "Расписание тренировок";
            this.timetablePage.UseVisualStyleBackColor = true;
            // 
            // notificationsPage
            // 
            this.notificationsPage.Location = new System.Drawing.Point(4, 35);
            this.notificationsPage.Margin = new System.Windows.Forms.Padding(2);
            this.notificationsPage.Name = "notificationsPage";
            this.notificationsPage.Size = new System.Drawing.Size(713, 349);
            this.notificationsPage.TabIndex = 2;
            this.notificationsPage.Text = "Уведомления";
            this.notificationsPage.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.exitButton);
            this.mainPanel.Controls.Add(this.dataPanel);
            this.mainPanel.Controls.Add(this.clientLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(819, 487);
            this.mainPanel.TabIndex = 5;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::Sport_Assistent.Properties.Resources.free_icon_exit_1286853;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Location = new System.Drawing.Point(753, 10);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 26);
            this.exitButton.TabIndex = 6;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Zameni_Menia_Leha_sdelai_krasivo
            // 
            this.Zameni_Menia_Leha_sdelai_krasivo.AutoSize = true;
            this.Zameni_Menia_Leha_sdelai_krasivo.Location = new System.Drawing.Point(26, 30);
            this.Zameni_Menia_Leha_sdelai_krasivo.Name = "Zameni_Menia_Leha_sdelai_krasivo";
            this.Zameni_Menia_Leha_sdelai_krasivo.Size = new System.Drawing.Size(241, 26);
            this.Zameni_Menia_Leha_sdelai_krasivo.TabIndex = 0;
            this.Zameni_Menia_Leha_sdelai_krasivo.Text = "Леша, читай название";
            this.Zameni_Menia_Leha_sdelai_krasivo.Click += new System.EventHandler(this.Zameni_Menia_Leha_sdelai_krasivo_Click);
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(26, 84);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(70, 26);
            this.surname.TabIndex = 1;
            this.surname.Text = "label1";
            this.surname.Click += new System.EventHandler(this.surname_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(26, 121);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 26);
            this.name.TabIndex = 2;
            this.name.Text = "label1";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // patronymic
            // 
            this.patronymic.AutoSize = true;
            this.patronymic.Location = new System.Drawing.Point(26, 163);
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(70, 26);
            this.patronymic.TabIndex = 3;
            this.patronymic.Text = "label1";
            this.patronymic.Click += new System.EventHandler(this.patronymic_Click);
            // 
            // ClientWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(819, 487);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientWind";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dataPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.profilePage.ResumeLayout(false);
            this.profilePage.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage subscriptionPage;
        private System.Windows.Forms.TabPage timetablePage;
        private System.Windows.Forms.TabPage notificationsPage;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TabPage profilePage;
        private System.Windows.Forms.Label Zameni_Menia_Leha_sdelai_krasivo;
        private System.Windows.Forms.Label patronymic;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
    }
}