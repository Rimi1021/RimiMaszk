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
    public partial class Debraktarattekintes : UserControl
    {
        public Debraktarattekintes()
        {
            InitializeComponent();
        }
        public static string Maszktipus = "";
        public static string Masznev = "";
        private void comboBox_Maszktipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Maszktipus.SelectedIndex == 0)
            {
                comboBox_Maszknev.Items.Clear();
                Maszktipus = comboBox_Maszktipus.SelectedItem.ToString();
                comboBox_Maszknev.Items.Add("Kek");
                comboBox_Maszknev.Items.Add("Terepmintas");
                comboBox_Maszknev.Items.Add("Zold");
                comboBox_Maszknev.Items.Add("Fekete");
                comboBox_Maszknev.Items.Add("Piros");
                comboBox_Maszknev.Items.Add("Feher");
                comboBox_Maszknev.Text = "Maszknév";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 1)
            {
                comboBox_Maszknev.Items.Clear();
                Maszktipus = comboBox_Maszktipus.SelectedItem.ToString();
                comboBox_Maszknev.Items.Add("Kek");
                comboBox_Maszknev.Items.Add("Rozsaszin");
                comboBox_Maszknev.Items.Add("Zold");
                comboBox_Maszknev.Items.Add("Fekete");
                comboBox_Maszknev.Items.Add("Sarga");
                comboBox_Maszknev.Items.Add("Feher");
                comboBox_Maszknev.Text = "Maszknév";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 2)
            {
                comboBox_Maszknev.Items.Clear();
                Maszktipus = comboBox_Maszktipus.SelectedItem.ToString();
                comboBox_Maszknev.Items.Add("Kek");
                comboBox_Maszknev.Items.Add("Terepmintas");
                comboBox_Maszknev.Items.Add("Zold");
                comboBox_Maszknev.Items.Add("Fekete");
                comboBox_Maszknev.Items.Add("Sarga");
                comboBox_Maszknev.Items.Add("Feher");
                comboBox_Maszknev.Text = "Maszknév";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 3)
            {
                comboBox_Maszknev.Items.Clear();
                Maszktipus = comboBox_Maszktipus.SelectedItem.ToString();
                comboBox_Maszknev.Items.Add("Kek");
                comboBox_Maszknev.Items.Add("Terepmintas");
                comboBox_Maszknev.Items.Add("Zold");
                comboBox_Maszknev.Items.Add("Fekete");
                comboBox_Maszknev.Items.Add("Sarga");
                comboBox_Maszknev.Items.Add("Feher");
                comboBox_Maszknev.Text = "Maszknév";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 4)
            {
                comboBox_Maszknev.Items.Clear();
                Maszktipus = comboBox_Maszktipus.SelectedItem.ToString();
                comboBox_Maszknev.Items.Add("Kek");
                comboBox_Maszknev.Items.Add("Hupikek");
                comboBox_Maszknev.Items.Add("Zold");
                comboBox_Maszknev.Items.Add("Fekete");
                comboBox_Maszknev.Items.Add("Rozsaszin");
                comboBox_Maszknev.Items.Add("Feher");
                comboBox_Maszknev.Text = "Maszknév";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 5)
            {
                comboBox_Maszknev.Items.Clear();
                Maszktipus = comboBox_Maszktipus.SelectedItem.ToString();
                comboBox_Maszknev.Items.Add("Marvel");
                comboBox_Maszknev.Items.Add("DC");
                comboBox_Maszknev.Items.Add("Frozen");
                comboBox_Maszknev.Items.Add("Csipkes");
                comboBox_Maszknev.Items.Add("Shrek");
                comboBox_Maszknev.Items.Add("Memes");
                comboBox_Maszknev.Text = "Maszknév";
            }
            else
            {
                Maszktipus = comboBox_Maszktipus.SelectedItem.ToString();
                comboBox_Maszknev.Items.Add("Marvel");
                comboBox_Maszknev.Items.Add("DC");
                comboBox_Maszknev.Items.Add("Frozen");
                comboBox_Maszknev.Items.Add("Csipkes");
                comboBox_Maszknev.Items.Add("Shrek");
                comboBox_Maszknev.Items.Add("Memes");
                comboBox_Maszknev.Items.Add("Kek");
                comboBox_Maszknev.Items.Add("Terepmintas");
                comboBox_Maszknev.Items.Add("Zold");
                comboBox_Maszknev.Items.Add("Fekete");
                comboBox_Maszknev.Items.Add("Sarga");
                comboBox_Maszknev.Items.Add("Feher");
                comboBox_Maszknev.Items.Add("Piros");
                comboBox_Maszknev.Items.Add("Hupikek");
                comboBox_Maszknev.Items.Add("Rozsaszin");
            }
        }

        private void comboBox_Maszknev_SelectedIndexChanged(object sender, EventArgs e)
        {
            Masznev = comboBox_Maszknev.SelectedItem.ToString();
        }
    }
}
