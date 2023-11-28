using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_Assistent
{
    public interface IMainPanel
    {
        Panel MainPanel { get; }
    }
    public static class VisualEffects
    {
        public static Form MainWind;

        public static void WindowChange(IMainPanel newWind)
        {
            MainWind.Controls.Clear();
            newWind.MainPanel.Dock = DockStyle.Fill;
            MainWind.Controls.Add(newWind.MainPanel);
        }
    }
}
