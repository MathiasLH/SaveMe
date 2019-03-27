using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUItest
{
    public partial class Form1 : Form
    {
        Panel panel;
        public Form1()
        {
            InitializeComponent();
            panel = mainPanel;
            mainMenu mainMenuCtrl = new mainMenu();
            panel.Controls.Add(mainMenuCtrl);

        }

        public void changeToMenu1()
        {
            menu1 menu1Ctrl = new menu1();
            panel.Controls.Add(menu1Ctrl);
        }

    }
}
