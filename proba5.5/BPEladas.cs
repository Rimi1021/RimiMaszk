using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace proba5._5
{
    public partial class BPEladas : UserControl
    {
        public BPEladas()
        {
            InitializeComponent();
            Raktar.Tisztalista();
        }
        bool vanilyenbarcode = false;
        const double ADO_KULCS = 0.27;
        public static string MaszktipusEladas = "";
        public static string MaszknevEladas = "";
        public static int MaxFelvihetoOsszeg = 0;
        public static int Felvittdb = 0;


        /// Encode Decode gombok
        #region Encode Decode buttonok
        private void button_Encode_Click(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            if (textBox_Encode.Text != "")
            {
                pictureBox_Barcode.Image = writer.Write(textBox_Encode.Text);
                textBox_Kosarba.Text = textBox_Encode.Text;
            }
            else
            {
                MessageBox.Show("Nincs Kódolandó vonalkód!");
                pictureBox_Barcode.Image = null;
                textBox_Kosarba.Text = "";
            }
        }

        private void button_Decode_Click(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            if (pictureBox_Barcode.Image != null)
            {
                var result = reader.Decode((Bitmap)pictureBox_Barcode.Image);
                if (result != null)
                {
                    textBox_Decode.Text = result.Text;
                    textBox_Kosarba.Text = textBox_Decode.Text;
                }
            }
            else
            {
                MessageBox.Show("Nincs Dekódolandó vódolandó vonalkód!");
                textBox_Kosarba.Text = "";
                textBox_Decode.Text = "";
            }
        }
        #endregion

        ///Kosárba tevés melletti textboxBarcode vizsgálat
        private void textBox_Kosarba_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].Barcode == textBox_Kosarba.Text)
                {
                    label_akcio.Text = "Akció:" +Convert.ToString(SzerverData.MaszInfokOsszes[i].Akcio)+"%";
                    vanilyenbarcode = true;
                    label_Adottarubrutto.Text = Convert.ToString(Aruvisszavetel.Brutto(SzerverData.MaszInfokOsszes[i].Ar_db))+" Ft";
                    if (SzerverData.MaszInfokOsszes[i].Akcio != 0)
                    {
                        label_Adottarubruttoakcio.Text =Convert.ToString(Aruvisszavetel.akcio(Aruvisszavetel.Brutto(SzerverData.MaszInfokOsszes[i].Ar_db), SzerverData.MaszInfokOsszes[i].Akcio))+" Ft";
                    }
                    else
                    {
                        label_Adottarubruttoakcio.Text = "Nincs akció";
                    }
                }
            }
            if (vanilyenbarcode == false && textBox_Kosarba.Text != "")
            {
                MessageBox.Show("Nem létezik ilyen vonalkód, használja a manuális termékkiválasztás opciót");
                textBox_Decode.Text = "";
                textBox_Encode.Text = "";
                textBox_Kosarba.Text = "";
            }
        }

        private void comboBox_Maszktipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaszknevEladas = "";
            comboboxitemchanges(comboBox_Maszktipus, comboBox_Maszknev);
            MaszktipusEladas = comboBox_Maszktipus.SelectedItem.ToString();
        }


        //Combobox fuggveny
        #region ComboBOX fugveny
        public static void comboboxitemchanges(ComboBox maszktipuscombobx, ComboBox maszknevcombobx)
        {
            if (maszktipuscombobx.SelectedIndex == 0)
            {
                maszknevcombobx.Items.Clear();
                maszknevcombobx.Items.Add("Kek");
                maszknevcombobx.Items.Add("Terepmintas");
                maszknevcombobx.Items.Add("Zold");
                maszknevcombobx.Items.Add("Fekete");
                maszknevcombobx.Items.Add("Piros");
                maszknevcombobx.Items.Add("Feher");

                maszknevcombobx.Text = "Maszknév";
            }
            else if (maszktipuscombobx.SelectedIndex == 1)
            {
                maszknevcombobx.Items.Clear();
                maszknevcombobx.Items.Add("Kek");
                maszknevcombobx.Items.Add("Rozsaszin");
                maszknevcombobx.Items.Add("Zold");
                maszknevcombobx.Items.Add("Fekete");
                maszknevcombobx.Items.Add("Sarga");
                maszknevcombobx.Items.Add("Feher");

                maszknevcombobx.Text = "Maszknév";
            }
            else if (maszktipuscombobx.SelectedIndex == 2)
            {
                maszknevcombobx.Items.Clear();
                maszknevcombobx.Items.Add("Kek");
                maszknevcombobx.Items.Add("Terepmintas");
                maszknevcombobx.Items.Add("Zold");
                maszknevcombobx.Items.Add("Fekete");
                maszknevcombobx.Items.Add("Sarga");
                maszknevcombobx.Items.Add("Feher");

                maszknevcombobx.Text = "Maszknév";
            }
            else if (maszktipuscombobx.SelectedIndex == 3)
            {
                maszknevcombobx.Items.Clear();
                maszknevcombobx.Items.Add("Kek");
                maszknevcombobx.Items.Add("Terepmintas");
                maszknevcombobx.Items.Add("Zold");
                maszknevcombobx.Items.Add("Fekete");
                maszknevcombobx.Items.Add("Sarga");
                maszknevcombobx.Items.Add("Feher");

                maszknevcombobx.Text = "Maszknév";
            }
            else if (maszktipuscombobx.SelectedIndex == 4)
            {
                maszknevcombobx.Items.Clear();
                maszknevcombobx.Items.Add("Kek");
                maszknevcombobx.Items.Add("Hupikek");
                maszknevcombobx.Items.Add("Zold");
                maszknevcombobx.Items.Add("Fekete");
                maszknevcombobx.Items.Add("Rozsaszin");
                maszknevcombobx.Items.Add("Feher");

                maszknevcombobx.Text = "Maszknév";
            }
            else
            {
                maszknevcombobx.Items.Clear();
                maszknevcombobx.Items.Add("Marvel");
                maszknevcombobx.Items.Add("DC");
                maszknevcombobx.Items.Add("Frozen");
                maszknevcombobx.Items.Add("Csipkes");
                maszknevcombobx.Items.Add("Shrek");
                maszknevcombobx.Items.Add("Memes");

                maszknevcombobx.Text = "Maszknév";
            }
        }
        #endregion


        // Nem használt text event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Raktar.rg.IsMatch(textBox1.Text))
            {
                Felvittdb = Convert.ToInt32(textBox1.Text);
            }
        }

        private void comboBox_Maszknev_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaszknevEladas = comboBox_Maszknev.SelectedItem.ToString();
        }

        private void button_Hozzaadas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].Maszktipus == MaszktipusEladas && SzerverData.MaszInfokOsszes[i].Maszknev == MaszknevEladas)
                {
                    MaxFelvihetoOsszeg = Convert.ToInt32(SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest);
                }
            }
            System.Diagnostics.Debug.WriteLine($"max db: {MaxFelvihetoOsszeg}");
            if (MaszktipusEladas != "" && MaszknevEladas != "")
            {
                if (Raktar.rg.IsMatch(textBox1.Text) && Convert.ToInt32(textBox1.Text) <= MaxFelvihetoOsszeg)
                {
                    for (int i = 0; i < Felvittdb; i++)
                    {
                        for (int j = 0; j < SzerverData.MaszInfokOsszes.Count; j++)
                        {
                            if (SzerverData.MaszInfokOsszes[j].Maszktipus == MaszktipusEladas && SzerverData.MaszInfokOsszes[j].Maszknev == MaszknevEladas)
                            {
                                System.Diagnostics.Debug.WriteLine($"bpkeszlet: {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest}");
                                listBox_Kosar.Items.Add($"{SzerverData.MaszInfokOsszes[j].Maszktipus}; {SzerverData.MaszInfokOsszes[j].Maszknev}; {SzerverData.MaszInfokOsszes[j].Ar_db}Ft; {SzerverData.MaszInfokOsszes[j].Akcio}%; {SzerverData.MaszInfokOsszes[j].Barcode}");
                                //MaxFelvihetoOsszeg = MaxFelvihetoOsszeg - Felvittdb;
                                SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest = SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest - Felvittdb;
                                System.Diagnostics.Debug.WriteLine($"bpkeszlet: {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest}");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Csak számot írhat a darabszámhoz és az eladottt darabszám nem haladhatja meg a a készletmennyiséget");
                }
            }
            else
            {
                MessageBox.Show("Válassza ki a termék típusát és a nevét");
            }
        }

        private void button_Torle_Click(object sender, EventArgs e)
        {
            Raktar.Tisztalista();
            listBox_Kosar.Items.Clear();
        }

        private void button_Hozzaadas2_Click(object sender, EventArgs e)
        {
            if (vanilyenbarcode == true)
            {
                for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                {
                    if (SzerverData.MaszInfokOsszes[i].Barcode == textBox_Kosarba.Text)
                    {
                        listBox_Kosar.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].Ar_db}Ft; {SzerverData.MaszInfokOsszes[i].Akcio}%; {SzerverData.MaszInfokOsszes[i].Barcode}");
                        vanilyenbarcode = false;
                        pictureBox_Barcode.Image = null;
                        textBox_Encode.Text = "";
                        textBox_Decode.Text = "";
                        textBox_Kosarba.Text = "";
                        label_Adottarubrutto.Text = "";
                        label_Adottarubruttoakcio.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincs ilyen termék! Rossz Vonalkód!");
            }
        }
    }
}
