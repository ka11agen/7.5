using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f = new About();
            f.ShowDialog();
        }

        private void beginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Begin f = new Begin();
            f.ShowDialog();
        }
    }
}
