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
    public partial class AdminWind : Form, IMainPanel
    {
        public Panel MainPanel
        {
            get { return mainPanel; }
        }

        public AdminWind()
        {
            InitializeComponent();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminWind_Load(object sender, EventArgs e)
        {
            
        }

        private void mainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            VisualEffects.WindowChange(new EntryWind());
        }
    }
}
