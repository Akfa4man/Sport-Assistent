namespace Sport_Assistent
{
    partial class SPAdminWind
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.distributionTrainersPage = new System.Windows.Forms.TabPage();
            this.clientDataPage = new System.Windows.Forms.TabPage();
            this.analysisPage = new System.Windows.Forms.TabPage();
            this.spAdminLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(44, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 530);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.distributionTrainersPage);
            this.tabControl1.Controls.Add(this.clientDataPage);
            this.tabControl1.Controls.Add(this.analysisPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(19, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(970, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // distributionTrainersPage
            // 
            this.distributionTrainersPage.Location = new System.Drawing.Point(4, 40);
            this.distributionTrainersPage.Name = "distributionTrainersPage";
            this.distributionTrainersPage.Padding = new System.Windows.Forms.Padding(3);
            this.distributionTrainersPage.Size = new System.Drawing.Size(962, 444);
            this.distributionTrainersPage.TabIndex = 0;
            this.distributionTrainersPage.Text = "Распределение тренеров";
            this.distributionTrainersPage.UseVisualStyleBackColor = true;
            // 
            // clientDataPage
            // 
            this.clientDataPage.Location = new System.Drawing.Point(4, 40);
            this.clientDataPage.Name = "clientDataPage";
            this.clientDataPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientDataPage.Size = new System.Drawing.Size(962, 444);
            this.clientDataPage.TabIndex = 1;
            this.clientDataPage.Text = "Управление клиентскими данными";
            this.clientDataPage.UseVisualStyleBackColor = true;
            // 
            // analysisPage
            // 
            this.analysisPage.Location = new System.Drawing.Point(4, 40);
            this.analysisPage.Name = "analysisPage";
            this.analysisPage.Size = new System.Drawing.Size(962, 444);
            this.analysisPage.TabIndex = 2;
            this.analysisPage.Text = "Мониторинг и анализ";
            this.analysisPage.UseVisualStyleBackColor = true;
            // 
            // spAdminLabel
            // 
            this.spAdminLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spAdminLabel.AutoSize = true;
            this.spAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spAdminLabel.Location = new System.Drawing.Point(360, 18);
            this.spAdminLabel.Name = "spAdminLabel";
            this.spAdminLabel.Size = new System.Drawing.Size(416, 29);
            this.spAdminLabel.TabIndex = 4;
            this.spAdminLabel.Text = "Администратор спорткомплекса";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.exitButton);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.spAdminLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1092, 599);
            this.mainPanel.TabIndex = 5;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::Sport_Assistent.Properties.Resources.free_icon_exit_1286853;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Location = new System.Drawing.Point(1011, 15);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(33, 32);
            this.exitButton.TabIndex = 7;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SPAdminWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1092, 599);
            this.Controls.Add(this.mainPanel);
            this.Name = "SPAdminWind";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SPAdminWind_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label spAdminLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage distributionTrainersPage;
        private System.Windows.Forms.TabPage clientDataPage;
        private System.Windows.Forms.TabPage analysisPage;
        private System.Windows.Forms.Button exitButton;
    }
}