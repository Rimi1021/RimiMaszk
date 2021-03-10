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
    public partial class Debraktarattekintes : UserControl
    {
        public Debraktarattekintes()
        {
            InitializeComponent();
        }
        public static string Maszktipus = "";
        public static string Masznev = "";
        public static string txtboxdefault = "Áru";
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
                comboBox_Maszknev.Items.Add("Osszes");
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
                comboBox_Maszknev.Items.Add("Osszes");
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
                comboBox_Maszknev.Items.Add("Osszes");
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
                comboBox_Maszknev.Items.Add("Osszes");
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
                comboBox_Maszknev.Items.Add("Osszes");
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
                comboBox_Maszknev.Items.Add("Osszes");
                comboBox_Maszknev.Text = "Maszknév";
            }
            else
            {
                comboBox_Maszknev.Items.Clear();
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
                comboBox_Maszknev.Items.Add("Osszes");
                comboBox_Maszknev.Items.Add("Rozsaszin");
            }
        }

        private void comboBox_Maszknev_SelectedIndexChanged(object sender, EventArgs e)
        {
            Masznev = comboBox_Maszknev.SelectedItem.ToString();
        }

        private void button_Listazas_Click(object sender, EventArgs e)
        {
            if (radioButton_BP.Checked == false && radioButton_GY.Checked == false && radioButton_Debrecen.Checked == false)
            {
                MessageBox.Show("Válassza ki melyik telephelyen lévő raktárkészletre kíváncsi!");
            }
            else if (Maszktipus == "" || Masznev == "")
            {
                MessageBox.Show("Válassza ki melyik terméktipusokat szertné kilistázni");
            }
            else
            {
                Raktar.Tisztalista();

                ///Budapest
                if (radioButton_BP.Checked == true)
                {
                    listBox1.Items.Add("Budapesti készlet:");
                    if (Maszktipus == "Osszes" && Masznev != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszknev == Masznev)
                            {
                                listBox1.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                    $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (Masznev == "Osszes" && Maszktipus != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == Maszktipus)
                            {
                                listBox1.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (Masznev == "Osszes" && Maszktipus == "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            listBox1.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                    $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == Maszktipus && SzerverData.MaszInfokOsszes[i].Maszknev == Masznev)
                            {
                                listBox1.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                }

                /// Győr
                else if (radioButton_GY.Checked == true)
                {
                    listBox1.Items.Add("Győri készlet:");
                    if (Maszktipus == "Osszes" && Masznev != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszknev == Masznev)
                            {
                                listBox1.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarGyor} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (Masznev == "Osszes" && Maszktipus != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == Maszktipus)
                            {
                                listBox1.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarGyor} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                    $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (Masznev == "Osszes" && Maszktipus == "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            listBox1.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarGyor} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == Maszktipus && SzerverData.MaszInfokOsszes[i].Maszknev == Masznev)
                            {
                                listBox1.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarGyor} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                }

                //Debrecen
                else
                {
                    listBox1.Items.Add("Debreceni készlet:");
                    if (Maszktipus == "Osszes" && Masznev != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszknev == Masznev)
                            {
                                listBox1.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (Masznev == "Osszes" && Maszktipus != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == Maszktipus)
                            {
                                listBox1.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                    $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (Masznev == "Osszes" && Maszktipus == "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            listBox1.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == Maszktipus && SzerverData.MaszInfokOsszes[i].Maszknev == Masznev)
                            {
                                listBox1.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                }
            }
        }

        private void button_Torles_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button_Export_Click(object sender, EventArgs e)
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

        private void textBox_Export_TextChanged(object sender, EventArgs e)
        {
            txtboxdefault = textBox_Export.Text;
        }
    }
}
