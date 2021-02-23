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
    public partial class Aruatcsoportositas : UserControl
    {
        public Aruatcsoportositas()
        {
            InitializeComponent();
        }

        #region radiobuttonok
        //VAN picturebox
        private void radioButton_BP_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(64, 60, 64);
        }

        private void radioButton_Gyor_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(97, 201, 35);
        }

        private void radioButton_Debrecen_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(0, 204, 204);
        }

        ///Raktár bictureBox
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(64, 60, 64);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(97, 201, 35);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(0, 204, 204);
        }
        #endregion
    }
}
