using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba5._5
{
    public partial class Raktar : UserControl
    {
        public Raktar()
        {
            InitializeComponent();
        }
        Regex rg = new Regex(@"^[0-9]+$");
        public static int szam1 = 0;
        public static int szam2 = 0;
        public static int szam3 = 0;
        public static int szam4 = 0;
        public static int szam5 = 0;
        public static int szam6 = 0;


        /// <summary>
        /// Elsőnek a + - gombok és a textbox change eventeket írom le az alábbiakban.
        /// A felső public stattic szam x valtozók idejonnek
        /// Mindegyik sorhoz van egy event a textbox érték manuális megváltoztatása miatt, amit darabszamvaltozas x-nek neveztem el
        /// HIBA!!! Ha karaktert írunk bele KÖLL egy regef feltétel
        /// </summary>
        #region +- gombok és textChangeeventek 
        //1.Sor
        private void button_1_1plusz_Click(object sender, EventArgs e)
        {
            szam1++;
            textBox_1_1.Text = Convert.ToString(szam1);
        }
        private void darabszamvaltozas(object sender, EventArgs e)
        {
            if (rg.IsMatch(textBox_1_1.Text))
            {
                if (textBox_1_1.Text == "")
                {
                    szam1 = 0;
                }
                else
                {
                    szam1 = Convert.ToInt32(textBox_1_1.Text);
                }
            }
            else
            {
                MessageBox.Show("Csak számot írhatsz bele");
            }
            
        }

        private void button1_1minusz_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_1_1.Text) > 0)
            {
                szam1--;
                textBox_1_1.Text = Convert.ToString(szam1);
            }
            else
            {
                MessageBox.Show("Negatív érték nem lehet");
            }
        }

        //2.Sor
        private void button_2_2plusz_Click(object sender, EventArgs e)
        {
            szam2++;
            textBox_2_2.Text = Convert.ToString(szam2);
        }

        private void button2_2minusz_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_2_2.Text) > 0)
            {
                szam2--;
                textBox_2_2.Text = Convert.ToString(szam2);
            }
            else
            {
                MessageBox.Show("Negatív érték nem lehet");
            }
        }

        private void darabszamvaltozas2(object sender, EventArgs e)
        {
            if (rg.IsMatch(textBox_2_2.Text))
            {
                if (textBox_2_2.Text == "")
                {
                    szam2 = 0;
                }
                else
                {
                    szam2 = Convert.ToInt32(textBox_2_2.Text);
                }
            }
            else
            {
                MessageBox.Show("Csak számot írhatsz bele");
            }
        }

        //3.Sor
        private void button_3_3plusz_Click(object sender, EventArgs e)
        {
            szam3++;
            textBox_3_3.Text = Convert.ToString(szam3);
        }

        private void button3_3minusz_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_3_3.Text) > 0)
            {
                szam3--;
                textBox_3_3.Text = Convert.ToString(szam3);
            }
            else
            {
                MessageBox.Show("Negatív érték nem lehet");
            }
        }

        private void darabszamvaltozas3(object sender, EventArgs e)
        {
            if (rg.IsMatch(textBox_3_3.Text))
            {
                if (textBox_3_3.Text == "")
                {
                    szam3 = 0;
                }
                else
                {
                    szam3 = Convert.ToInt32(textBox_3_3.Text);
                }
            }
            else
            {
                MessageBox.Show("Csak számot írhatsz bele");
            }
        }

        //4.Sor
        private void button_4_4plusz_Click(object sender, EventArgs e)
        {
            szam4++;
            textBox_4_4.Text = Convert.ToString(szam4);
        }

        private void button4_4minusz_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_4_4.Text) > 0)
            {
                szam4--;
                textBox_4_4.Text = Convert.ToString(szam4);
            }
            else
            {
                MessageBox.Show("Negatív érték nem lehet");
            }
        }

        private void darabszamvaltozas4(object sender, EventArgs e)
        {
            if (rg.IsMatch(textBox_4_4.Text))
            {
                if (textBox_4_4.Text == "")
                {
                    szam4 = 0;
                }
                else
                {
                    szam4 = Convert.ToInt32(textBox_4_4.Text);
                }
            }
            else
            {
                MessageBox.Show("Csak számot írhatsz bele");
            }
        }

        //5.Sor
        private void button_5_5plusz_Click(object sender, EventArgs e)
        {
            szam5++;
            textBox_5_5.Text = Convert.ToString(szam5);
        }

        private void button5_5minusz_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_5_5.Text) > 0)
            {
                szam5--;
                textBox_5_5.Text = Convert.ToString(szam5);
            }
            else
            {
                MessageBox.Show("Negatív érték nem lehet");
            }
        }

        private void darabszamvaltozas5(object sender, EventArgs e)
        {
            if (rg.IsMatch(textBox_5_5.Text))
            {
                if (textBox_5_5.Text == "")
                {
                    szam5 = 0;
                }
                else
                {
                    szam5 = Convert.ToInt32(textBox_5_5.Text);
                }
            }
            else
            {
                MessageBox.Show("Csak számot írhatsz bele");
            }
        }

        //5.Sor
        private void button_6_6plusz_Click(object sender, EventArgs e)
        {
            szam6++;
            textBox_6_6.Text = Convert.ToString(szam6);
        }

        private void button6_6minusz_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox_6_6.Text) > 0)
            {
                szam6--;
                textBox_6_6.Text = Convert.ToString(szam6);
            }
            else
            {
                MessageBox.Show("Negatív érték nem lehet");
            }
        }

        private void darabszamvaltozas6(object sender, EventArgs e)
        {
            if (rg.IsMatch(textBox_6_6.Text))
            {
                if (textBox_6_6.Text == "")
                {
                    szam6 = 0;
                }
                else
                {
                    szam6 = Convert.ToInt32(textBox_6_6.Text);
                }
            }
            else
            {
                MessageBox.Show("Csak számot írhatsz bele");
            }
        }
        #endregion
        /// <summary>
        /// + -  Gombok és textbocChangek Vége
        /// /// </summary>
        /// 

        /// <summary>
        /// FELTÖLTÉS GOMBOK
        /// /// </summary>
        /// 

        private void button_Arufelvitel1_Click(object sender, EventArgs e)
        {
            //Budapest
            if (radioButtonBP.Checked == true)
            {
                if (comboBox_Maszktipus.SelectedItem == "Gazmaszk")
                {
                    if (rg.IsMatch(textBox_1_1.Text) && Convert.ToInt32(textBox_1_1.Text) > 0 && Convert.ToInt32(textBox_1_1.Text) < 999)
                    {
                        int valtozo = Convert.ToInt32(textBox_1_1.Text);
                        for (int i = 0; i < valtozo; i++)
                        {
                            try
                            {
                                using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                                {
                                    string Feltoltes = "INSERT INTO MaszkAruk VALUES (@masztipusAdat,@maszknevAdat,@keszletarubpAdat,@keszletarugyAdat,@keszletarudAdat,@ardbAdat,@akcioAdat)"; //Adatok feltöltése
                                    using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                                    {
                                        Parancs.Parameters.AddWithValue("@masztipusAdat", comboBox_Maszktipus.SelectedItem); //Hivatkozott paraméter értékeinek megadása
                                        Parancs.Parameters.AddWithValue("@maszknevAdat", label_maszknev1.Text); //Hivatkozott paraméter értékeinek megadása
                                        Parancs.Parameters.AddWithValue("@keszletarubpAdat",1);
                                        Parancs.Parameters.AddWithValue("@keszletarugyAdat",null); 
                                        Parancs.Parameters.AddWithValue("@keszletarudAdat",null);
                                        Parancs.Parameters.AddWithValue("@ardbAdat",null);
                                        Parancs.Parameters.AddWithValue("@akcioAdat",null);
                                        Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                                        var result = Parancs.ExecuteNonQuery();
                                        Parancs.Dispose();
                                        // Hiba keresés, ha nem lett eredmény
                                        if (result < 0)
                                        { MessageBox.Show("Hiba az adatfeltöltés során!"); } //Hibaüzenet
                                        MessageBox.Show("A feltöltés megtörtént!"); //Sikeres feltöltés esetén megjelenő üzenet
                                        Csatlakozas.Close(); //Csatlakozási folyamat lezárása
                                    }
                                }
                            }
                            catch (Exception) //Kivétel megadása, ha a try részben lévő kód nem fut le.
                            { MessageBox.Show("Nem sikerült a csalakozás"); } //Feltöltési probléma esetén megjelenő üzenet
                            textBox_1_1.Text = "0"; //Aktuális elemek "kiürítése"
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
               /* else if (comboBox_Maszktipus.SelectedItem == "Szelepes")
                {

                }
                else if (comboBox_Maszktipus.SelectedItem == "Fashion")
                {

                }
                else if (comboBox_Maszktipus.SelectedItem == "Szűrős")
                {

                }
                else if (comboBox_Maszktipus.SelectedItem == "Egyszerhasználatos")
                {

                }
                else if (comboBox_Maszktipus.SelectedItem == "Mintás")
                {

                }
                else
                {
                    MessageBox.Show("Válassza ki a MASZKTÍPUST");
                }*/
            }
           /* //Győr
            else if (radioButtonGY.Checked == true)
            {

            }
            //Debrecen
            else if (radioButtonD.Checked == true)
            {

            }
            //Egyiksem
            else
            {
                MessageBox.Show("Válassza ki a Telephelyet");
            }*/
        }

        /// <summary>
        /// FELTÖLTÉS GOMBOK vége
        /// /// </summary>

        /// <summary>
        /// /Combobox textevent
        /// </summary>

        private void comboBox_Maszktipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Maszktipus.SelectedIndex == 0) //gaymasyk
            {
                label_maszknev1.Text = "Kék";
                label_maszknev2.Text = "Terepmintás";
                label_maszknev3.Text = "Zöld";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sárga";
                label_maszknev6.Text = "Fehér";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 1) //szelepes
            {
                label_maszknev1.Text = "Kék";
                label_maszknev2.Text = "Rózsaszin";
                label_maszknev3.Text = "Zöld";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sárga";
                label_maszknev6.Text = "Fehér";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 2) //fashion
            {
                label_maszknev1.Text = "Kék";
                label_maszknev2.Text = "Terepmintás";
                label_maszknev3.Text = "Zöld";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sárga";
                label_maszknev6.Text = "Fehér";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 3) //szuros
            {
                label_maszknev1.Text = "Kék";
                label_maszknev2.Text = "Terepmintás";
                label_maszknev3.Text = "Zöld";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Sárga";
                label_maszknev6.Text = "Fehér";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 4) //egyszerhasznalatos
            {
                label_maszknev1.Text = "Kék";
                label_maszknev2.Text = "Hupikék";
                label_maszknev3.Text = "Zöld";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Rózsaszín";
                label_maszknev6.Text = "Fehér";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 5) //mintás
            {
                label_maszknev1.Text = "Marvel";
                label_maszknev2.Text = "DC";
                label_maszknev3.Text = "Frozen";
                label_maszknev4.Text = "Csipkés";
                label_maszknev5.Text = "Shrek";
                label_maszknev6.Text = "Mémes";
            }
        }

        
    }
}
