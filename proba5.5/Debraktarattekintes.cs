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
            Listazasfuggveny(radioButton_BP,radioButton_GY, radioButton_Debrecen, listBox1, Maszktipus, Masznev);
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



        /// <summary>
        /// Listázás fuggveny
        /// </summary>
        public static void Listazasfuggveny(RadioButton BP, RadioButton GY, RadioButton D, ListBox LB, string masktype, string maskname) 
        {
            if (BP.Checked == false && GY.Checked == false && D.Checked == false)
            {
                MessageBox.Show("Válassza ki melyik telephelyen lévő raktárkészletre kíváncsi!");
            }
            else if (masktype == "" || maskname == "")
            {
                MessageBox.Show("Válassza ki melyik terméktipusokat szertné kilistázni");
            }
            else
            {
                Raktar.Tisztalista();

                ///Budapest
                if (BP.Checked == true)
                {
                    LB.Items.Add("Budapesti készlet:");
                    if (masktype == "Osszes" && maskname != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszknev == maskname)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                    $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (maskname == "Osszes" && masktype != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == masktype)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (maskname == "Osszes" && masktype == "Osszes")
                    {
                        LB.Items.Clear();
                        LB.Items.Add("Összes Maszktípus/Maszknev:");
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                    $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == masktype && SzerverData.MaszInfokOsszes[i].Maszknev == maskname)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarBudapest} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                }

                /// Győr
                else if (GY.Checked == true)
                {
                    LB.Items.Add("Győri készlet:");
                    if (masktype == "Osszes" && maskname != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszknev == maskname)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarGyor} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (maskname == "Osszes" && masktype != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == masktype)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarGyor} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                    $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (maskname == "Osszes" && masktype == "Osszes")
                    {
                        LB.Items.Clear();
                        LB.Items.Add("Összes Maszktípus/Maszknev:");
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarGyor} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == masktype && SzerverData.MaszInfokOsszes[i].Maszknev == maskname)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarGyor} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                }

                //Debrecen
                else
                {
                    LB.Items.Add("Debreceni készlet:");
                    if (masktype == "Osszes" && Masznev != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszknev == maskname)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (maskname == "Osszes" && masktype != "Osszes")
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == masktype)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                    $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                    else if (maskname == "Osszes" && masktype == "Osszes")
                    {
                        LB.Items.Clear();
                        LB.Items.Add("Összes Maszktípus/Maszknev:");
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < SzerverData.MaszInfokOsszes.Count; i++)
                        {
                            if (SzerverData.MaszInfokOsszes[i].Maszktipus == masktype && SzerverData.MaszInfokOsszes[i].Maszknev == maskname)
                            {
                                LB.Items.Add($"{SzerverData.MaszInfokOsszes[i].Maszktipus}; {SzerverData.MaszInfokOsszes[i].Maszknev}; {SzerverData.MaszInfokOsszes[i].KeszletraktarDebrecen} db; {SzerverData.MaszInfokOsszes[i].Ar_db} FT;" +
                                   $"{SzerverData.MaszInfokOsszes[i].Akcio}%; Vonalkód: {SzerverData.MaszInfokOsszes[i].Barcode} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
