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
    public partial class BeginWind : Form, IMainPanel
    {
        public Panel MainPanel
        {
            get { return mainPanel; }
        }

        public BeginWind()
        {
            InitializeComponent();
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            VisualEffects.WindowChange(new EntryWind());
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void beginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BeginWind_Load(object sender, EventArgs e)
        {
            VisualEffects.MainWind=this;
        }
    }
}
