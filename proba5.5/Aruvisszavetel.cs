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
    public partial class Aruvisszavetel : UserControl
    {
        public Aruvisszavetel()
        {
            InitializeComponent();
        }

        //ComboboxSelectItem
        #region combobox selectItem
        private void comboBox_Maszktipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Maszktipus.SelectedIndex == 0) //gaymasyk
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Piros";
                label_maszknev6.Text = "Feher";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 1) //szelepes
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Rozsaszin";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sarga";
                label_maszknev6.Text = "Feher";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 2) //fashion
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sarga";
                label_maszknev6.Text = "Feher";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 3) //szuros
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sarga";
                label_maszknev6.Text = "Feher";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 4) //egyszerhasznalatos
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Hupikek";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Rozsaszin";
                label_maszknev6.Text = "Feher";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 5) //mintás
            {
                label_maszknev1.Text = "Marvel";
                label_maszknev2.Text = "DC";
                label_maszknev3.Text = "Frozen";
                label_maszknev4.Text = "Csipkes";
                label_maszknev5.Text = "Shrek";
                label_maszknev6.Text = "Memes";
            }
        }
        #endregion
        //ComboEvents
        #region
        private void BP(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 60, 64);
        }

        private void GY(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(97, 201, 35);
        }

        private void D(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 204, 204);
        }
        #endregion
    }
}
