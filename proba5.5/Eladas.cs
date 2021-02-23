using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proba5._5
{
    public partial class Eladas : UserControl
    {
        public Eladas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public static string Location4querry = "";
        public static string Termek4querry = "";
        #region radiobuttons
        private void szinvaltozasradiogomb(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 60, 64);
            Location4querry = "keszletarubudapest";
        }

        private void hatterszinradiobuttongyor(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(97, 201, 35);
            Location4querry = "keszletarugyor";
        }

        private void hatterszinradiobuttondebrecen(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 204, 204);
            Location4querry = "keszletarudebrecen";
        }

        private void hatterosszesradiobutton(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(144, 155, 39);
        }

        #endregion

        #region Comboboxevents
        private void termekvaltozas(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0) //gaymasyk
            {
                Termek4querry = "Gazmaszk";
            }
            else if (comboBox.SelectedIndex == 1) //szelepes
            {
                Termek4querry = "Szelepes";
            }
            else if (comboBox.SelectedIndex == 2) //fashion
            {
                Termek4querry = "Fashion";
            }
            else if (comboBox.SelectedIndex == 3) //szuros
            {
                Termek4querry = "Szuros";
            }
            else if (comboBox.SelectedIndex == 4) //egyszerhasznalatos
            {
                Termek4querry = "Egyszerhasznalatos";
            }
            else if (comboBox.SelectedIndex == 5) //mintás
            {
                Termek4querry = "Mintas";
            }
        }

        #endregion

        private void button_Listazas_Click(object sender, EventArgs e)
        {
            listBox_Lista.Items.Clear();
            if (radioButtonBP.Checked == false && radioButtonGY.Checked == false && radioButtonD.Checked == false && radioButton_Osszes.Checked == false) //Ha Radiobutton ures
            {
                MessageBox.Show("Válassza ki a telephelyet");
            }
            else if (comboBox.SelectedItem == null) //Ha combo űres 
            {
                MessageBox.Show("Válasszon a termék csoprtok közül");
            }
            else if (radioButton_Osszes.Checked == true && comboBox.SelectedItem.ToString() == "Osszes") //HA radio és combobox Összes-Összes
            {
                Raktar.Tisztalista();
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    listBox_Lista.Items.Add(SzerverData.MaszInfokOsszes[i].Maszktipus + ";" + SzerverData.MaszInfokOsszes[i].Maszknev + ";" + SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest + "db;" + SzerverData.MaszInfokOsszes[i].Ar_db +"Ft"+";"+ SzerverData.MaszInfokOsszes[i].Akcio+ "%_Akcio" + ";BUdapest");
                }
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    listBox_Lista.Items.Add(SzerverData.MaszInfokOsszes[i].Maszktipus + ";" + SzerverData.MaszInfokOsszes[i].Maszknev + ";" + SzerverData.MaszInfokOsszes[i].KeszletraktarGyor + "db;" + SzerverData.MaszInfokOsszes[i].Ar_db + "Ft" + ";" + SzerverData.MaszInfokOsszes[i].Akcio + "%_Akcio" + ";Győr");
                }
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    listBox_Lista.Items.Add(SzerverData.MaszInfokOsszes[i].Maszktipus + ";" + SzerverData.MaszInfokOsszes[i].Maszknev + ";" + SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen + "db;" + SzerverData.MaszInfokOsszes[i].Ar_db + "Ft" + ";" + SzerverData.MaszInfokOsszes[i].Akcio +"%_Akcio"+ ";Debrecen");
                }
            }
            else if (radioButton_Osszes.Checked == true && comboBox.SelectedItem.ToString() != "Osszes") // Ha radio Osszes combo nem Osszes
            {
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].Maszktipus == Termek4querry)
                    {
                        listBox_Lista.Items.Add(SzerverData.MaszInfokOsszes[i].Maszktipus + ";" + SzerverData.MaszInfokOsszes[i].Maszknev + ";" + SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest + "db;" + SzerverData.MaszInfokOsszes[i].Ar_db + "Ft" + ";" + SzerverData.MaszInfokOsszes[i].Akcio + "%_Akcio" + ";BUdapest");
                        listBox_Lista.Items.Add(SzerverData.MaszInfokOsszes[i].Maszktipus + ";" + SzerverData.MaszInfokOsszes[i].Maszknev + ";" + SzerverData.MaszInfokOsszes[i].KeszletraktarGyor + "db;" + SzerverData.MaszInfokOsszes[i].Ar_db + "Ft" + ";" + SzerverData.MaszInfokOsszes[i].Akcio + "%_Akcio" + ";Győr");
                        listBox_Lista.Items.Add(SzerverData.MaszInfokOsszes[i].Maszktipus + ";" + SzerverData.MaszInfokOsszes[i].Maszknev + ";" + SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen + "db;" + SzerverData.MaszInfokOsszes[i].Ar_db + "Ft" + ";" + SzerverData.MaszInfokOsszes[i].Akcio + "%_Akcio" + ";Debrecen");
                    }
                }
            }
            else if (radioButton_Osszes.Checked != true && comboBox.SelectedItem.ToString() == "Osszes") ///Ha Radio nem osszes, de combo igen
            {
                 string Lekeredezes = $"SELECT * FROM MaszkAruk WHERE COLUMN_NAME='{Location4querry}'";
                 using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                 {
                     using (SqlCommand Parancs = new SqlCommand(Lekeredezes, Csatlakozas))
                     {
                         Csatlakozas.Open();
                         SqlDataReader LekerdezesParancs = Parancs.ExecuteReader();
                         Parancs.Dispose();
                         while (LekerdezesParancs.Read())
                         {
                             listBox_Lista.Items.Add(LekerdezesParancs["maszktipus"] + ";" + LekerdezesParancs["maszknev"] + ";" + LekerdezesParancs[Location4querry] + ";" + LekerdezesParancs["ar/db"]+";"+ LekerdezesParancs["akcio"]);
                         }
                         MessageBox.Show("Az adatok kiolvasása megtörtént!", "Siker!", MessageBoxButtons.OK);
                         Csatlakozas.Close();
                     }
                 }
                

            }
        }
        #region Export
        private void button_export_Click(object sender, EventArgs e)
        {
            string csvfajlnev = textBox_Export.Text + ".csv";
            if (listBox_Lista.Items != null)
            {
                StreamWriter Iro = new StreamWriter(csvfajlnev, false, Encoding.Default);
                for (int i = 0; i < listBox_Lista.Items.Count; i++)
                {
                    Iro.WriteLine(listBox_Lista.Items[i].ToString());
                }
                Iro.Close();
                MessageBox.Show("Az írási folyamat végrehajtva");
            }
            else
            {
                MessageBox.Show("Először listázza ki az exportálandó adatokat");/////Ez a része nem jó
            }
        }
        #endregion
    }
}
