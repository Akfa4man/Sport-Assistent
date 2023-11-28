namespace Sport_Assistent
{
    partial class AccountantWind
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
            this.dataPanel = new System.Windows.Forms.Panel();
            this.dataTabControl = new System.Windows.Forms.TabControl();
            this.accountingPage = new System.Windows.Forms.TabPage();
            this.incomePage = new System.Windows.Forms.TabPage();
            this.controlDeptPage = new System.Windows.Forms.TabPage();
            this.financialReportsPage = new System.Windows.Forms.TabPage();
            this.accountingLabel = new System.Windows.Forms.Label();
            this.accountantLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.dataPanel.SuspendLayout();
            this.dataTabControl.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPanel
            // 
            this.dataPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataPanel.BackColor = System.Drawing.Color.Orange;
            this.dataPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dataPanel.Controls.Add(this.dataTabControl);
            this.dataPanel.Controls.Add(this.accountingLabel);
            this.dataPanel.Location = new System.Drawing.Point(38, 44);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(1010, 538);
            this.dataPanel.TabIndex = 0;
            // 
            // dataTabControl
            // 
            this.dataTabControl.Controls.Add(this.accountingPage);
            this.dataTabControl.Controls.Add(this.incomePage);
            this.dataTabControl.Controls.Add(this.controlDeptPage);
            this.dataTabControl.Controls.Add(this.financialReportsPage);
            this.dataTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataTabControl.Location = new System.Drawing.Point(40, 60);
            this.dataTabControl.Name = "dataTabControl";
            this.dataTabControl.SelectedIndex = 0;
            this.dataTabControl.Size = new System.Drawing.Size(925, 453);
            this.dataTabControl.TabIndex = 7;
            // 
            // accountingPage
            // 
            this.accountingPage.Location = new System.Drawing.Point(4, 40);
            this.accountingPage.Name = "accountingPage";
            this.accountingPage.Padding = new System.Windows.Forms.Padding(3);
            this.accountingPage.Size = new System.Drawing.Size(917, 409);
            this.accountingPage.TabIndex = 0;
            this.accountingPage.Text = "Учёт продаж абонементов";
            this.accountingPage.UseVisualStyleBackColor = true;
            // 
            // incomePage
            // 
            this.incomePage.Location = new System.Drawing.Point(4, 40);
            this.incomePage.Name = "incomePage";
            this.incomePage.Padding = new System.Windows.Forms.Padding(3);
            this.incomePage.Size = new System.Drawing.Size(917, 409);
            this.incomePage.TabIndex = 1;
            this.incomePage.Text = "Расчёт доходов";
            this.incomePage.UseVisualStyleBackColor = true;
            // 
            // controlDeptPage
            // 
            this.controlDeptPage.Location = new System.Drawing.Point(4, 40);
            this.controlDeptPage.Name = "controlDeptPage";
            this.controlDeptPage.Size = new System.Drawing.Size(917, 409);
            this.controlDeptPage.TabIndex = 2;
            this.controlDeptPage.Text = "Контроль задолженновтей клиентов";
            this.controlDeptPage.UseVisualStyleBackColor = true;
            // 
            // financialReportsPage
            // 
            this.financialReportsPage.Location = new System.Drawing.Point(4, 40);
            this.financialReportsPage.Name = "financialReportsPage";
            this.financialReportsPage.Size = new System.Drawing.Size(917, 409);
            this.financialReportsPage.TabIndex = 3;
            this.financialReportsPage.Text = "Генерация отчётов о финансовых показателях";
            this.financialReportsPage.UseVisualStyleBackColor = true;
            // 
            // accountingLabel
            // 
            this.accountingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountingLabel.AutoSize = true;
            this.accountingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountingLabel.Location = new System.Drawing.Point(396, 15);
            this.accountingLabel.Name = "accountingLabel";
            this.accountingLabel.Size = new System.Drawing.Size(263, 32);
            this.accountingLabel.TabIndex = 6;
            this.accountingLabel.Text = "Финансовый учёт";
            // 
            // accountantLabel
            // 
            this.accountantLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accountantLabel.AutoSize = true;
            this.accountantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountantLabel.Location = new System.Drawing.Point(496, 12);
            this.accountantLabel.Name = "accountantLabel";
            this.accountantLabel.Size = new System.Drawing.Size(137, 29);
            this.accountantLabel.TabIndex = 0;
            this.accountantLabel.Text = "Бухгалтер";
            this.accountantLabel.Click += new System.EventHandler(this.accountantLabel_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.Controls.Add(this.exitButton);
            this.mainPanel.Controls.Add(this.accountantLabel);
            this.mainPanel.Controls.Add(this.dataPanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1092, 599);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::Sport_Assistent.Properties.Resources.free_icon_exit_1286853;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Location = new System.Drawing.Point(1015, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(33, 32);
            this.exitButton.TabIndex = 7;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AccountantWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 599);
            this.Controls.Add(this.mainPanel);
            this.Name = "AccountantWind";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AccountantWind_Load);
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.dataTabControl.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Label accountantLabel;
        private System.Windows.Forms.Label accountingLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TabControl dataTabControl;
        private System.Windows.Forms.TabPage accountingPage;
        private System.Windows.Forms.TabPage incomePage;
        private System.Windows.Forms.TabPage controlDeptPage;
        private System.Windows.Forms.TabPage financialReportsPage;
        private System.Windows.Forms.Button exitButton;
    }
}