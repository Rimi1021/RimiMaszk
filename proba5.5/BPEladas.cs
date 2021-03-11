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
        }
        bool vanilyenbarcode = false;


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
            Raktar.Tisztalista();
            for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
            {
                if (SzerverData.MaszInfokOsszes[i].Barcode == textBox_Kosarba.Text)
                {
                    vanilyenbarcode = true;
                    label_Adottarubrutto.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Ar_db);
                    label_Adottarubruttoakcio.Text = Convert.ToString(SzerverData.MaszInfokOsszes[i].Ar_db);
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
    }
}
