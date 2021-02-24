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
            Raktar.Tisztalista();
        }
        public static string Honnan = "";
        public static string Hova = "";
        public static string Termektipus = "";
        public static string Termeknev = "";
        public static bool maszkkombo = false;
        public static bool Szallitasra_Alkalmas = false;
        public static bool MegadottdbTextboxba = false;
        public static int db = 0;
        #region radiobuttonok
        //VAN picturebox
        private void radioButton_BP_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(64, 60, 64);
            Honnan = "Budapest";
            label_Honnan.Text = "Budapest";
        }

        private void radioButton_Gyor_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(97, 201, 35);
            Honnan = "Gyor";
            label_Honnan.Text = "Győr";
        }

        private void radioButton_Debrecen_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(0, 204, 204);
            Honnan = "Debrecen";
            label_Honnan.Text = "Debrecen";
        }

        ///Raktár bictureBox
        private void radioButton4_CheckedChanged(object sender, EventArgs e) //BP
        {
            pictureBox1.BackColor = Color.FromArgb(64, 60, 64);
            Hova = "Budapest";
            label_Hova.Text = "Budapest";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)//Győr
        {
            pictureBox1.BackColor = Color.FromArgb(97, 201, 35);
            Hova = "Gyor";
            label_Hova.Text = "Győr";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)//Debrecen
        {
            pictureBox1.BackColor = Color.FromArgb(0, 204, 204);
            Hova = "Debrecen";
            label_Hova.Text = "Debrecen";
        }
        #endregion

        //Combobox Events
        #region Combobox
        private void MasztipusShange(object sender, EventArgs e)
        {
            Termektipus = comboBox_Maszktipus.SelectedItem.ToString();
        }

        private void Maszknevchange(object sender, EventArgs e)
        {
            Termeknev = comboBox_Maszknev.SelectedItem.ToString();
        }

        #endregion

        private void button_Találat_Click(object sender, EventArgs e)
        {
            vizsgalat();
            if (radioButton_BP.Checked == false && radioButton_Gyor.Checked == false && radioButton_Debrecen.Checked == false) //Ha Radiobutton ures
            {
                MessageBox.Show("Válassza ki a telephelyet");
            }
            else if (comboBox_Maszktipus.SelectedItem == null || comboBox_Maszknev.SelectedItem == null) //Ha combo űres 
            {
                MessageBox.Show("Válassza ki a termék csoportot és termék fajtát");
            }
            else if (maszkkombo == true)
            {
                MessageBox.Show("Ez jo lesz");
                Szallitasra_Alkalmas = true;
                label_Maszktipus.Text = Termektipus;
                label_Maszknev.Text = Termeknev;
                label_Maszkdb.Text = Convert.ToString(db);
            }
            else
            {
                MessageBox.Show("Nem létező maszktípus-név kombináció");
            }
            maszkkombo = false;
        }

        #region Termékkombóvizsgálat
        public static void vizsgalat() 
        {
            for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].Maszktipus == Termektipus && SzerverData.MaszInfokOsszes[i].Maszknev == Termeknev)
                {
                    maszkkombo = true;
                    if (Honnan == "Budapest")
                    {
                        db = SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest;
                    }
                    else if (Honnan == "Gyor")
                    {
                        db = SzerverData.MaszInfokOsszes[i].KeszletraktarGyor;
                    }
                    else
                    {
                        db = SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen;
                    }
                }
            }
        }
        #endregion

        private void textBox_atcsoportositDB_TextChanged(object sender, EventArgs e)
        {
            if (Raktar.rg.IsMatch(textBox_atcsoportositDB.Text) && db >= Convert.ToInt32(textBox_atcsoportositDB.Text) && Convert.ToInt32(textBox_atcsoportositDB.Text) != 0)
            {
                MegadottdbTextboxba = true;
            }
            else
            {
                MessageBox.Show("Csak számot adhatsz meg ami nem lehet 0 és a megadott érték nem lehet nagyobb a jelenlegi darabszámnál");
                textBox_atcsoportositDB.Text = "";
                MegadottdbTextboxba = false;
            }
        }
    }
}
