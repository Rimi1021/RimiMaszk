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
                // maszknev label beallitasok
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Piros";
                label_maszknev6.Text = "Feher";

                // maszktipus elmentese kesobbi keresesre
                maszktipus = "Gazmaszk";

                // Adatok kiirasa
                AdatokKiiratasa(label_maszknev1.Text, label_Brutto1, textBox_2_1, textBox_3_1, label_nettoakcio1, label_bruttoakcio1);
                AdatokKiiratasa(label_maszknev2.Text, label_Brutto2, textBox_2_2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2);
                AdatokKiiratasa(label_maszknev3.Text, label_Brutto3, textBox_2_3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3);
                AdatokKiiratasa(label_maszknev4.Text, label_Brutto4, textBox_2_4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4);
                AdatokKiiratasa(label_maszknev5.Text, label_Brutto5, textBox_2_5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5);
                AdatokKiiratasa(label_maszknev6.Text, label_Brutto6, textBox_2_6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6);
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
                AdatokKiiratasa(label_maszknev1.Text, label_Brutto1, textBox_2_1, textBox_3_1, label_nettoakcio1, label_bruttoakcio1);
                AdatokKiiratasa(label_maszknev2.Text, label_Brutto2, textBox_2_2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2);
                AdatokKiiratasa(label_maszknev3.Text, label_Brutto3, textBox_2_3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3);
                AdatokKiiratasa(label_maszknev4.Text, label_Brutto4, textBox_2_4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4);
                AdatokKiiratasa(label_maszknev5.Text, label_Brutto5, textBox_2_5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5);
                AdatokKiiratasa(label_maszknev6.Text, label_Brutto6, textBox_2_6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6);
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
                AdatokKiiratasa(label_maszknev1.Text, label_Brutto1, textBox_2_1, textBox_3_1, label_nettoakcio1, label_bruttoakcio1);
                AdatokKiiratasa(label_maszknev2.Text, label_Brutto2, textBox_2_2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2);
                AdatokKiiratasa(label_maszknev3.Text, label_Brutto3, textBox_2_3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3);
                AdatokKiiratasa(label_maszknev4.Text, label_Brutto4, textBox_2_4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4);
                AdatokKiiratasa(label_maszknev5.Text, label_Brutto5, textBox_2_5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5);
                AdatokKiiratasa(label_maszknev6.Text, label_Brutto6, textBox_2_6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6);
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
                AdatokKiiratasa(label_maszknev1.Text, label_Brutto1, textBox_2_1, textBox_3_1, label_nettoakcio1, label_bruttoakcio1);
                AdatokKiiratasa(label_maszknev2.Text, label_Brutto2, textBox_2_2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2);
                AdatokKiiratasa(label_maszknev3.Text, label_Brutto3, textBox_2_3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3);
                AdatokKiiratasa(label_maszknev4.Text, label_Brutto4, textBox_2_4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4);
                AdatokKiiratasa(label_maszknev5.Text, label_Brutto5, textBox_2_5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5);
                AdatokKiiratasa(label_maszknev6.Text, label_Brutto6, textBox_2_6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6);
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
                AdatokKiiratasa(label_maszknev1.Text, label_Brutto1, textBox_2_1, textBox_3_1, label_nettoakcio1, label_bruttoakcio1);
                AdatokKiiratasa(label_maszknev2.Text, label_Brutto2, textBox_2_2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2);
                AdatokKiiratasa(label_maszknev3.Text, label_Brutto3, textBox_2_3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3);
                AdatokKiiratasa(label_maszknev4.Text, label_Brutto4, textBox_2_4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4);
                AdatokKiiratasa(label_maszknev5.Text, label_Brutto5, textBox_2_5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5);
                AdatokKiiratasa(label_maszknev6.Text, label_Brutto6, textBox_2_6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6);
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
                AdatokKiiratasa(label_maszknev1.Text, label_Brutto1, textBox_2_1, textBox_3_1, label_nettoakcio1, label_bruttoakcio1);
                AdatokKiiratasa(label_maszknev2.Text, label_Brutto2, textBox_2_2, textBox_3_2, label_nettoakcio2, label_bruttoakcio2);
                AdatokKiiratasa(label_maszknev3.Text, label_Brutto3, textBox_2_3, textBox_3_3, label_nettoakcio3, label_bruttoakcio3);
                AdatokKiiratasa(label_maszknev4.Text, label_Brutto4, textBox_2_4, textBox_3_4, label_nettoakcio4, label_bruttoakcio4);
                AdatokKiiratasa(label_maszknev5.Text, label_Brutto5, textBox_2_5, textBox_3_5, label_nettoakcio5, label_bruttoakcio5);
                AdatokKiiratasa(label_maszknev6.Text, label_Brutto6, textBox_2_6, textBox_3_6, label_nettoakcio6, label_bruttoakcio6);
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

        public static void AdatokKiiratasa(string valtozomaszknev, Label label1, TextBox textbx2, TextBox textbx3, Label label2, Label label3) 
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
                    if (SzerverData.MaszInfokOsszes[i].Akcio != 0)
                    {
                        label2.Text = Convert.ToString(akcio(SzerverData.MaszInfokOsszes[i].Ar_db, SzerverData.MaszInfokOsszes[i].Akcio));
                        label3.Text = Convert.ToString(akcio(Convert.ToDouble(label1.Text), SzerverData.MaszInfokOsszes[i].Akcio)); 
                    }
                    else
                    {
                        label2.Text = "Nincs akció";
                        label3.Text = "Nincs akció";
                    }
                }
            }
        }

        //System.Diagnostics.Debug.WriteLine("megtortenikbudapest");
        public static double Brutto(double NettoOsszeg) 
        {
            double BruttoOsszeg =  NettoOsszeg * (1 + ADO_KULCS) ;
            return BruttoOsszeg;
        }

        public static double akcio(double osszeg, double magaazakcio)
        {
            osszeg = osszeg - (magaazakcio / 100 * osszeg);
            return osszeg;
        }

    }
}
