using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_Assistent
{
    public partial class AccountantWind : Form, IMainPanel
    {
        public Panel MainPanel
        {
            get { return mainPanel; }
        }

        public AccountantWind()
        {
            InitializeComponent();
        }

        private void AccountantWind_Load(object sender, EventArgs e)
        {
        
        }
        private void Recalculation()
        {
            MessageBox.Show("Коммит 5");
        }

        private void accountantLabel_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void financialPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            VisualEffects.WindowChange(new EntryWind());
        }

        private void dataPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
