namespace Sport_Assistent
{
    partial class TrainerWind
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
            this.trainerPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timetablePage = new System.Windows.Forms.TabPage();
            this.notificationsPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.trainerLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.trainerPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trainerPanel
            // 
            this.trainerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trainerPanel.BackColor = System.Drawing.Color.Orange;
            this.trainerPanel.Controls.Add(this.tabControl1);
            this.trainerPanel.Controls.Add(this.label2);
            this.trainerPanel.Location = new System.Drawing.Point(43, 56);
            this.trainerPanel.Name = "trainerPanel";
            this.trainerPanel.Size = new System.Drawing.Size(1010, 524);
            this.trainerPanel.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.timetablePage);
            this.tabControl1.Controls.Add(this.notificationsPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(25, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 483);
            this.tabControl1.TabIndex = 10;
            // 
            // timetablePage
            // 
            this.timetablePage.Location = new System.Drawing.Point(4, 40);
            this.timetablePage.Name = "timetablePage";
            this.timetablePage.Padding = new System.Windows.Forms.Padding(3);
            this.timetablePage.Size = new System.Drawing.Size(955, 439);
            this.timetablePage.TabIndex = 0;
            this.timetablePage.Text = "Расписание тренировок";
            this.timetablePage.UseVisualStyleBackColor = true;
            // 
            // notificationsPage
            // 
            this.notificationsPage.Location = new System.Drawing.Point(4, 40);
            this.notificationsPage.Name = "notificationsPage";
            this.notificationsPage.Padding = new System.Windows.Forms.Padding(3);
            this.notificationsPage.Size = new System.Drawing.Size(955, 439);
            this.notificationsPage.TabIndex = 1;
            this.notificationsPage.Text = "Уведомления";
            this.notificationsPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(825, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 9;
            // 
            // trainerLabel
            // 
            this.trainerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trainerLabel.AutoSize = true;
            this.trainerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainerLabel.Location = new System.Drawing.Point(504, 24);
            this.trainerLabel.Name = "trainerLabel";
            this.trainerLabel.Size = new System.Drawing.Size(104, 29);
            this.trainerLabel.TabIndex = 2;
            this.trainerLabel.Text = "Тренер";
            this.trainerLabel.Click += new System.EventHandler(this.trainerLabel_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.exitButton);
            this.mainPanel.Controls.Add(this.trainerPanel);
            this.mainPanel.Controls.Add(this.trainerLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1092, 599);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::Sport_Assistent.Properties.Resources.free_icon_exit_1286853;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Location = new System.Drawing.Point(998, 18);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(33, 32);
            this.exitButton.TabIndex = 7;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // TrainerWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1092, 599);
            this.Controls.Add(this.mainPanel);
            this.Name = "TrainerWind";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TrainerWind_Load);
            this.trainerPanel.ResumeLayout(false);
            this.trainerPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel trainerPanel;
        private System.Windows.Forms.Label trainerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage timetablePage;
        private System.Windows.Forms.TabPage notificationsPage;
        private System.Windows.Forms.Button exitButton;
    }
}