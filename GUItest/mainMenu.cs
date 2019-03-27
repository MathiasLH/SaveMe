using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUItest
{
    public partial class mainMenu : UserControl
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void menu1_button_Click(object sender, EventArgs e)
        {
            menu1 menu1Ctrl = new menu1();
            Parent.Controls.Add(menu1Ctrl);
            Parent.Controls.Remove(this);
        }

        private void menu2_button_Click(object sender, EventArgs e)
        {
            characterSelector charSel = new characterSelector();
            Parent.Controls.Add(charSel);
            Parent.Controls.Remove(this);
        }

        private void menu3_button_Click(object sender, EventArgs e)
        {
            settings settingsMenu = new settings();
            Parent.Controls.Add(settingsMenu);
            Parent.Controls.Remove(this);
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
