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
        public static string maszktipus = "";
        const double ADO_KULCS = 0.27;

        //ComboboxSelectItem
        #region combobox selectItem
        private void comboBox_Maszktipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Maszktipus.SelectedIndex == 0) //gaymasyk/
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Piros";
                label_maszknev6.Text = "Feher";
                maszktipus = "Gazmaszk";
                AdatokKiiratasa(label_maszknev1.Text, label_Brutto1, textBox_2_1, textBox_3_1);
            }
            else if (comboBox_Maszktipus.SelectedIndex == 1) //szelepes
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Rozsaszin";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sarga";
                label_maszknev6.Text = "Feher";
                maszktipus = "Szelepes";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 2) //fashion
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sarga";
                label_maszknev6.Text = "Feher";
                maszktipus = "Fashion";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 3) //szuros
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sarga";
                label_maszknev6.Text = "Feher";
                maszktipus = "Szuros";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 4) //egyszerhasznalatos
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Hupikek";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Rozsaszin";
                label_maszknev6.Text = "Feher";
                maszktipus = "Egyszerhasznalatos";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 5) //mintás
            {
                label_maszknev1.Text = "Marvel";
                label_maszknev2.Text = "DC";
                label_maszknev3.Text = "Frozen";
                label_maszknev4.Text = "Csipkes";
                label_maszknev5.Text = "Shrek";
                label_maszknev6.Text = "Memes";
                maszktipus = "Mintas";
            }
        }
        #endregion
        //ComboEvents
        #region radiobuttonok amik mar nincsenek
        /*
        private void BP(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 60, 64);
            Regio = "Budapest";
        }

        private void GY(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(97, 201, 35);
            Regio = "Gyor";
        }

        private void D(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 204, 204);
            Regio = "Debrecen";
        }*/
        #endregion

        public static void AdatokKiiratasa(string valtozomaszknev, Label label1, TextBox textbx2, TextBox textbx3) 
        {
            Raktar.Tisztalista();
            for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].Maszktipus == maszktipus && SzerverData.MaszInfokOsszes[i].Maszknev == valtozomaszknev)
                {
                    double x = Brutto(SzerverData.MaszInfokOsszes[i].Ar_db);
                    label1.Text = Convert.ToString(x);
                    textbx2.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Ar_db);
                    textbx3.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Akcio);
                }
            }
        }

        //System.Diagnostics.Debug.WriteLine("megtortenikbudapest");
        public static double Brutto(double NettoOsszeg) 
        {
            double BruttoOsszeg =  NettoOsszeg * (1 + ADO_KULCS) ;
            return BruttoOsszeg;
        }

    }
}
