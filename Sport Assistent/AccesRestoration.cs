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
    public partial class AccesRestorationWind : Form, IMainPanel
    {
        public Panel MainPanel
        {
            get { return mainPanel; }
        }

        public AccesRestorationWind()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Доступ разрешён");
        }

        private void AccesRestorationWind_Load(object sender, EventArgs e)
        {
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
