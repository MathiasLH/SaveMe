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
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
        }

        private void goback_Click(object sender, EventArgs e)
        {
            mainMenu mainmenuCtrl = new mainMenu();
            Parent.Controls.Add(mainmenuCtrl);
            Parent.Controls.Remove(this);
        }
    }
}
