namespace Sport_Assistent
{
    partial class AdminWind
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
            this.adminLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.dataTabControl = new System.Windows.Forms.TabControl();
            this.accesControlPage = new System.Windows.Forms.TabPage();
            this.problemPage = new System.Windows.Forms.TabPage();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.dataTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminLabel
            // 
            this.adminLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminLabel.Location = new System.Drawing.Point(454, 25);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(207, 29);
            this.adminLabel.TabIndex = 2;
            this.adminLabel.Text = "Администратор";
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainPanel.Controls.Add(this.exitButton);
            this.mainPanel.Controls.Add(this.dataPanel);
            this.mainPanel.Controls.Add(this.adminLabel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1092, 599);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint_1);
            // 
            // dataPanel
            // 
            this.dataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataPanel.BackColor = System.Drawing.Color.Orange;
            this.dataPanel.Controls.Add(this.dataTabControl);
            this.dataPanel.Location = new System.Drawing.Point(70, 66);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(953, 507);
            this.dataPanel.TabIndex = 1;
            this.dataPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // dataTabControl
            // 
            this.dataTabControl.Controls.Add(this.accesControlPage);
            this.dataTabControl.Controls.Add(this.problemPage);
            this.dataTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataTabControl.Location = new System.Drawing.Point(27, 25);
            this.dataTabControl.Name = "dataTabControl";
            this.dataTabControl.SelectedIndex = 0;
            this.dataTabControl.Size = new System.Drawing.Size(895, 459);
            this.dataTabControl.TabIndex = 0;
            // 
            // accesControlPage
            // 
            this.accesControlPage.Location = new System.Drawing.Point(4, 40);
            this.accesControlPage.Name = "accesControlPage";
            this.accesControlPage.Padding = new System.Windows.Forms.Padding(3);
            this.accesControlPage.Size = new System.Drawing.Size(887, 415);
            this.accesControlPage.TabIndex = 0;
            this.accesControlPage.Text = "Контроль доступа";
            this.accesControlPage.UseVisualStyleBackColor = true;
            // 
            // problemPage
            // 
            this.problemPage.Location = new System.Drawing.Point(4, 40);
            this.problemPage.Name = "problemPage";
            this.problemPage.Padding = new System.Windows.Forms.Padding(3);
            this.problemPage.Size = new System.Drawing.Size(887, 415);
            this.problemPage.TabIndex = 1;
            this.problemPage.Text = "Уведомления о неполадках";
            this.problemPage.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::Sport_Assistent.Properties.Resources.free_icon_exit_1286853;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Location = new System.Drawing.Point(990, 22);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(33, 32);
            this.exitButton.TabIndex = 7;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AdminWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1092, 599);
            this.Controls.Add(this.mainPanel);
            this.Name = "AdminWind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminWind_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            this.dataTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.TabControl dataTabControl;
        private System.Windows.Forms.TabPage accesControlPage;
        private System.Windows.Forms.TabPage problemPage;
        private System.Windows.Forms.Button exitButton;
    }
}