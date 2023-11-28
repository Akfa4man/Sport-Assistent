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
    public partial class RegistrationWind : Form, IMainPanel
    {
        public Panel MainPanel
        {
            get { return mainPanel; }
        }

        public RegistrationWind()
        {
            InitializeComponent();
        }

        private void entryLabel_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationWind_Load(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            VisualEffects.WindowChange(new EntryWind());
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
