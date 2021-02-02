using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba5._5
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            felhasznalohozzaAdas1.Hide();
        }

        private void button_felhasznalohozzaadas_Click(object sender, EventArgs e)
        {
            felhasznalohozzaAdas1.Show();
            felhasznalohozzaAdas1.BringToFront();
        }
    }
}
