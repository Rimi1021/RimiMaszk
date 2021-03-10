using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba5._5
{
    public partial class BPAruattekintes : UserControl
    {
        public BPAruattekintes()
        {
            InitializeComponent();
        }
        public static string Maszktipus = "";
        public static string Masznev = "";
        public static string txtboxdefault = "Áru";

        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debraktarattekintes.Fuggvenycoboboxra(comboBox_Type, comboBox_Nev);
            Maszktipus = comboBox_Type.SelectedItem.ToString();
        }

        private void button_Listazas_Click(object sender, EventArgs e)
        {
            Debraktarattekintes.Listazasfuggveny(radioButton_BP, radioButton_GY, radioButton_D, listBox1, Maszktipus, Masznev);
            System.Diagnostics.Debug.WriteLine($"Maszktipus: {Maszktipus}");
            System.Diagnostics.Debug.WriteLine($"Maszknev: {Masznev}");
        }

        private void comboBox_Nev_SelectedIndexChanged(object sender, EventArgs e)
        {
            Masznev = comboBox_Nev.SelectedItem.ToString();
        }

        private void button_listboxtorles_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox_Export_TextChanged(object sender, EventArgs e)
        {
            txtboxdefault = textBox_Export.Text;
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            if (txtboxdefault != "")
            {
                txtboxdefault += ".csv";
                if (listBox1.Items != null)
                {
                    StreamWriter Iro = new StreamWriter(txtboxdefault, false, Encoding.Default);
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        Iro.WriteLine(listBox1.Items[i].ToString());
                    }
                    Iro.Close();
                    MessageBox.Show("Az írási folyamat végrehajtva");
                }
                else
                {
                    MessageBox.Show("Először listázza ki az exportálandó adatokat");
                }
            }
            else
            {
                MessageBox.Show("Adjon nevet a CSV fájlnak");
            }
        }
    }
}
