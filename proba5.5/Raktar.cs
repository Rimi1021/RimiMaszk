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
                if (textBox_1_1.Text == "" || Convert.ToInt32(textBox_1_1.Text) == 0)
                {
                    szam1 = 0;
                    button_Arufelvitel1.BackColor = Color.FromArgb(255,128,128);
                }
                else
                {
                    szam1 = Convert.ToInt32(textBox_1_1.Text);
                    button_Arufelvitel1.BackColor = Color.Lime;
                }
            }
            else
            {
                MessageBox.Show("Csak számot írhatsz bele");
                button_Arufelvitel1.BackColor = Color.FromArgb(255, 128, 128);
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
                if (textBox_2_2.Text == "" || Convert.ToInt32(textBox_2_2.Text) == 0)
                {
                    szam2 = 0;
                    button_Arufelvitel2.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    szam2 = Convert.ToInt32(textBox_2_2.Text);
                    button_Arufelvitel2.BackColor = Color.Lime;
                }
            }
            else
            {
                MessageBox.Show("Csak számot írhatsz bele");
                button_Arufelvitel2.BackColor = Color.FromArgb(255, 128, 128);
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
                if (textBox_3_3.Text == "" || Convert.ToInt32(textBox_3_3.Text) == 0)
                {
                    szam3 = 0;
                    button_Arufelvitel3.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    szam3 = Convert.ToInt32(textBox_3_3.Text);
                    button_Arufelvitel3.BackColor = Color.Lime;
                }
            }
            else
            {
                MessageBox.Show("Csak számot írhatsz bele");
                button_Arufelvitel3.BackColor = Color.FromArgb(255, 128, 128);
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
                if (textBox_4_4.Text == "" || Convert.ToInt32(textBox_4_4.Text) == 0)
                {
                    szam4 = 0;
                    button_Arufelvitel4.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    szam4 = Convert.ToInt32(textBox_4_4.Text);
                    button_Arufelvitel4.BackColor = Color.Lime;
                }
            }
            else
            {
                MessageBox.Show("Csak számot írhatsz bele");
                button_Arufelvitel4.BackColor = Color.FromArgb(255, 128, 128);
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
                if (textBox_5_5.Text == "" || Convert.ToInt32(textBox_5_5.Text) == 0)
                {
                    szam5 = 0;
                    button_Arufelvitel5.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    szam5 = Convert.ToInt32(textBox_5_5.Text);
                    button_Arufelvitel5.BackColor = Color.Lime;
                }
            }
            else
            {
                MessageBox.Show("Csak számot írhatsz bele");
                button_Arufelvitel5.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        //6.Sor
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
                if (textBox_6_6.Text == "" || Convert.ToInt32(textBox_6_6.Text) == 0)
                {
                    szam6 = 0;
                    button_Arufelvitel6.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    szam6 = Convert.ToInt32(textBox_6_6.Text);
                    button_Arufelvitel6.BackColor = Color.Lime;
                }
            }
            else
            {
                MessageBox.Show("Csak számot írhatsz bele");
                button_Arufelvitel6.BackColor = Color.FromArgb(255, 128, 128);
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
        #region 1.Feltöltésgom Lajebb van a tobbi
        private void button_Arufelvitel1_Click(object sender, EventArgs e)
        {
            int valtozo = Convert.ToInt32(textBox_1_1.Text); // uj aru szam
            string maszktipusgui = Convert.ToString(comboBox_Maszktipus.SelectedItem);
            string maszknevgui = label_maszknev1.Text.ToString();

            // call methid

            //Budapest
            if (radioButtonBP.Checked == true)
            {

                if (rg.IsMatch(textBox_1_1.Text) && Convert.ToInt32(textBox_1_1.Text) > 0 && Convert.ToInt32(textBox_1_1.Text) < 999)
                {
                    // call method
                    update_aru_keszletBP(valtozo, maszknevgui, maszktipusgui);
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonGY.Checked == true)
            {

                if (rg.IsMatch(textBox_1_1.Text) && Convert.ToInt32(textBox_1_1.Text) > 0 && Convert.ToInt32(textBox_1_1.Text) < 999)
                {
                    // call method
                    update_aru_keszletGY(valtozo, maszknevgui, maszktipusgui);
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonD.Checked == true)
            {

                if (rg.IsMatch(textBox_1_1.Text) && Convert.ToInt32(textBox_1_1.Text) > 0 && Convert.ToInt32(textBox_1_1.Text) < 999)
                {
                    // call method
                    update_aru_keszletdebrecen(valtozo, maszknevgui, maszktipusgui);
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Válassza ki a régiót");
            }

        }
        #endregion


        //Updat metodus  buttonokra Budapestre
        #region Metódusok UPDATE
        public void update_aru_keszletBP(int valtozo,string maszknevgui,string maszktipusgui) 
        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                {
                    string Feltoltes = $"UPDATE MaszkAruk SET keszletarubudapest = keszletarubudapest + {valtozo} WHERE maszktipus='{maszktipusgui}' AND maszknev='{maszknevgui}'"; //Adatok feltöltése
                    using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                    {
                        Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                        var result = Parancs.ExecuteNonQuery(); //itt  baj
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

        //Updat metodus  buttonokra Győebe
        public void update_aru_keszletGY(int valtozo, string maszknevgui, string maszktipusgui)
        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                {
                    string Feltoltes = $"UPDATE MaszkAruk SET keszletarugyor = keszletarubudapest + {valtozo} WHERE maszktipus='{maszktipusgui}' AND maszknev='{maszknevgui}'"; //Adatok feltöltése
                    using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                    {
                        Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                        var result = Parancs.ExecuteNonQuery(); //itt  baj
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

        //Updat metodus  buttonokra Debrecenbe
        public void update_aru_keszletdebrecen(int valtozo, string maszknevgui, string maszktipusgui)
        {
            try
            {
                using (SqlConnection Csatlakozas = new SqlConnection(SzerverData.SzerverInfoAdmin))
                {
                    string Feltoltes = $"UPDATE MaszkAruk SET keszletarudebrecen = keszletarubudapest + {valtozo} WHERE maszktipus='{maszktipusgui}' AND maszknev='{maszknevgui}'"; //Adatok feltöltése
                    using (SqlCommand Parancs = new SqlCommand(Feltoltes, Csatlakozas))
                    {
                        Csatlakozas.Open(); //Csatlakozási folyamat megnyitása
                        var result = Parancs.ExecuteNonQuery(); //itt  baj
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
        #endregion
        /// <summary>
        /// FELTÖLTÉS GOMBOK vége
        /// /// </summary>

        /// <summary>
        /// /Combobox textevent
        /// </summary>
        #region combobox selectindex = Maszklabelek;
        private void comboBox_Maszktipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Maszktipus.SelectedIndex == 0) //gaymasyk
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Terepmintas";
                label_maszknev3.Text = "Zold";
                label_maszknev4.Text = "Fekete";
                label_maszknev5.Text = "Piros";
                label_maszknev6.Text = "Fehér";
            }
            else if (comboBox_Maszktipus.SelectedIndex == 1) //szelepes
            {
                label_maszknev1.Text = "Kek";
                label_maszknev2.Text = "Rozsaszin";
                label_maszknev3.Text = "Zöld";
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
                label_maszknev5.Text = "Rózsaszin";
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
        /// <summary>
        /// /Combobox textevent Vége
        /// </summary>


        /// <summary>
        /// /RadioButton eventek
        /// </summary>
        #region radiobutton eventek
        private void radioButtonBP_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64,60,64);
            label_Raktar.Text = "Raktár: Budapest";
        }

        private void radioButtonGY_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(97, 201, 35);
            label_Raktar.Text = "Raktár: Győr";
        }

        private void radioButtonD_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 204, 204); ;
            label_Raktar.Text = "Raktár: Debrecen";
        }
        #endregion


        //2.Gomb Felvitel
        #region  2.Gomb
        private void button_Arufelvitel2_Click(object sender, EventArgs e)
        {
            int valtozo = Convert.ToInt32(textBox_2_2.Text); // uj aru szam
            string maszktipusgui = Convert.ToString(comboBox_Maszktipus.SelectedItem);
            string maszknevgui = label_maszknev2.Text.ToString();

            // call methid

            //Budapest
            if (radioButtonBP.Checked == true)
            {

                if (rg.IsMatch(textBox_2_2.Text) && Convert.ToInt32(textBox_2_2.Text) > 0 && Convert.ToInt32(textBox_2_2.Text) < 999)
                {
                    // call method
                    update_aru_keszletBP(valtozo, maszknevgui, maszktipusgui);
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonGY.Checked == true)
            {

                if (rg.IsMatch(textBox_2_2.Text) && Convert.ToInt32(textBox_2_2.Text) > 0 && Convert.ToInt32(textBox_2_2.Text) < 999)
                {
                    // call method
                    update_aru_keszletGY(valtozo, maszknevgui, maszktipusgui);
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonD.Checked == true)
            {

                if (rg.IsMatch(textBox_2_2.Text) && Convert.ToInt32(textBox_2_2.Text) > 0 && Convert.ToInt32(textBox_2_2.Text) < 999)
                {
                    // call method
                    update_aru_keszletdebrecen(valtozo, maszknevgui, maszktipusgui);
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Válassza ki a régiót");
            }
        }
        #endregion



        /// 3.Gomb

        #region 3.Gomb
        private void button_Arufelvitel3_Click(object sender, EventArgs e)
        {
            int valtozo = Convert.ToInt32(textBox_3_3.Text); // uj aru szam
            string maszktipusgui = Convert.ToString(comboBox_Maszktipus.SelectedItem);
            string maszknevgui = label_maszknev3.Text.ToString();

            // call methid

            //Budapest
            if (radioButtonBP.Checked == true)
            {

                if (rg.IsMatch(textBox_3_3.Text) && Convert.ToInt32(textBox_3_3.Text) > 0 && Convert.ToInt32(textBox_3_3.Text) < 999)
                {
                    // call method
                    update_aru_keszletBP(valtozo, maszknevgui, maszktipusgui);
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonGY.Checked == true)
            {

                if (rg.IsMatch(textBox_3_3.Text) && Convert.ToInt32(textBox_3_3.Text) > 0 && Convert.ToInt32(textBox_3_3.Text) < 999)
                {
                    // call method
                    update_aru_keszletGY(valtozo, maszknevgui, maszktipusgui);
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else if (radioButtonD.Checked == true)
            {

                if (rg.IsMatch(textBox_2_2.Text) && Convert.ToInt32(textBox_2_2.Text) > 0 && Convert.ToInt32(textBox_2_2.Text) < 999)
                {
                    // call method
                    update_aru_keszletdebrecen(valtozo, maszknevgui, maszktipusgui);
                }
                else
                {
                    if (MessageBox.Show("Hiba a feltöltés során", "A feltöltendő mennyiség 0-1000 közé eshet és csak számot adhatsz meg", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Válassza ki a régiót");
            }
        }
        #endregion


        /// <summary>
        /// /RadioButton eventek vége
        /// </summary>
    }
}
