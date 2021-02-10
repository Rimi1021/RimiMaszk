﻿using System;
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
    public partial class ListazasTorles : UserControl
    {
        public ListazasTorles()
        {
            InitializeComponent();
        }

        private void button_Listazas_Click(object sender, EventArgs e)
        {
            checkboxvizsgalat();
            if (checkBox_Debuserek.Checked == false && checkBox_Gyoruserek.Checked == false && checkBox_BPuserek.Checked == false && checkBox_Adminuserek.Checked == false)
            {
                if (MessageBox.Show("A listázás sikertelen", "Nincs kijelölt checkbox", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    return;
                }
            }
            SzerverData.AdminUserLista.Clear();
            SzerverData.BPUserLista.Clear();
            SzerverData.GyorUserLista.Clear();
            SzerverData.DebUserLista.Clear();
        }

        public void checkboxvizsgalat() 
        {
            if (checkBox_Adminuserek.Checked == true)
            {
                ListakbaOlvasas.AdminListabaOlvasas();
                for (int i = 0; i < SzerverData.AdminUserLista.Count; i++)
                {
                    listBox_Felhasznalolistazas.Items.Add(SzerverData.AdminUserLista[i].Id + "; " + SzerverData.AdminUserLista[i].Nev + "; " + SzerverData.AdminUserLista[i].Jelszo);
                }
            }
            if (checkBox_BPuserek.Checked == true)
            {
                ListakbaOlvasas.BudapestUsersListabaOlvasas();
                for (int i = 0; i < SzerverData.BPUserLista.Count; i++)
                {
                    listBox_Felhasznalolistazas.Items.Add(SzerverData.BPUserLista[i].Id + "; " + SzerverData.BPUserLista[i].Nev + "; " + SzerverData.BPUserLista[i].Jelszo);
                }
            }
            if (checkBox_Gyoruserek.Checked == true)
            {
                ListakbaOlvasas.GyorUsersListabaOlvasas();
                for (int i = 0; i < SzerverData.GyorUserLista.Count; i++)
                {
                    listBox_Felhasznalolistazas.Items.Add(SzerverData.GyorUserLista[i].Id + "; " + SzerverData.GyorUserLista[i].Nev + "; " + SzerverData.GyorUserLista[i].Jelszo);
                }
            }
            if (checkBox_Debuserek.Checked == true)
            {
                ListakbaOlvasas.DebrecenUsersListabaOlvasas();
                for (int i = 0; i < SzerverData.DebUserLista.Count; i++)
                {
                    listBox_Felhasznalolistazas.Items.Add(SzerverData.DebUserLista[i].Id + "; " + SzerverData.DebUserLista[i].Nev + "; " + SzerverData.DebUserLista[i].Jelszo);
                }
            }
        }

        private void button_ListaBoxKijelzo_clear_Click(object sender, EventArgs e)
        {
            listBox_Felhasznalolistazas.Items.Clear();
        }

        private void button_Frissites_Click(object sender, EventArgs e)
        {
            listBox_Felhasznalolistazas.Items.Clear();
            SzerverData.AdminUserLista.Clear();
            SzerverData.BPUserLista.Clear();
            SzerverData.GyorUserLista.Clear();
            SzerverData.DebUserLista.Clear();
            checkboxvizsgalat();
            MessageBox.Show("A frissítés megtörtént");
        }

        private void Elemkiir(object sender, EventArgs e)
        {
            if (listBox_Felhasznalolistazas.SelectedItem != null) //Ha van kiválasztva lista item a dupla klikkeléskor
            {
                MessageBox.Show(listBox_Felhasznalolistazas.SelectedItem.ToString()); //Kiíratom a kijelölt listaelem adatait
            }
            else //Különben eset, ha az elem üres lenne
            {
                MessageBox.Show("Nincs kijelölt elem!"); //Hiba visszajelzése, ha üres az elem
            }
        }

        
        private void button_Export_Click(object sender, EventArgs e)
        {
            string csvfajlnev = textBox_Csv.Text + ".csv";
            if (listBox_Felhasznalolistazas.Items != null)
            {
                StreamWriter Iro = new StreamWriter(csvfajlnev,false,Encoding.Default);
                for (int i = 0; i < listBox_Felhasznalolistazas.Items.Count; i++)
                {
                    Iro.WriteLine(listBox_Felhasznalolistazas.Items[i].ToString());
                }
                Iro.Close();
                MessageBox.Show("Az írási folyamat végrehajtva");
            }
            else
            {
                MessageBox.Show("Először listázza ki az exportálandó adatokat");/////Ez a része nem jó
            }
        }

        private void button_Kereses_Click(object sender, EventArgs e)
        {
            if (textBox_NevKereses.Text != null)
            {
                listBox_Felhasznalolistazas.Items.Clear();
                ListakbaOlvasas.AdminListabaOlvasas();
                ListakbaOlvasas.BudapestUsersListabaOlvasas();
                ListakbaOlvasas.GyorUsersListabaOlvasas();
                ListakbaOlvasas.DebrecenUsersListabaOlvasas();
                bool Admin = false;
                bool BP = false;
                bool Deb = false;
                bool Gy = false;
                int index = 0;
                for (int i = 0; i < SzerverData.AdminUserLista.Count; i++)
                {
                    if (textBox_NevKereses.Text == SzerverData.AdminUserLista[i].Nev)
                    {
                        Admin = true;
                        index = i;
                    }
                }
                for (int i = 0; i < SzerverData.BPUserLista.Count; i++)
                {
                    if (textBox_NevKereses.Text == SzerverData.BPUserLista[i].Nev)
                    {
                        BP = true;
                        index = i;
                    }
                }
                for (int i = 0; i < SzerverData.GyorUserLista.Count; i++)
                {
                    if (textBox_NevKereses.Text == SzerverData.GyorUserLista[i].Nev)
                    {
                        Gy = true;
                        index = i;
                    }
                }
                for (int i = 0; i < SzerverData.DebUserLista.Count; i++)
                {
                    if (textBox_NevKereses.Text == SzerverData.DebUserLista[i].Nev)
                    {
                        Deb = true;
                        index = i;
                    }
                }
                if (Admin == true)
                {
                    listBox_Felhasznalolistazas.Items.Add($"{SzerverData.AdminUserLista[index].Id}; {SzerverData.AdminUserLista[index].Nev};{SzerverData.AdminUserLista[index].Jelszo} ADMINJOG");
                }
                else if (Deb == true)
                {
                    listBox_Felhasznalolistazas.Items.Add($"{SzerverData.DebUserLista[index].Id}; {SzerverData.DebUserLista[index].Nev};{SzerverData.DebUserLista[index].Jelszo} Debreceni felhasználó");
                }
                else if (BP == true)
                {
                    listBox_Felhasznalolistazas.Items.Add($"{SzerverData.BPUserLista[index].Id}; {SzerverData.BPUserLista[index].Nev};{SzerverData.BPUserLista[index].Jelszo} Budapesti felhasználó");
                }
                else if (Gy ==  true)
                {
                    listBox_Felhasznalolistazas.Items.Add($"{SzerverData.GyorUserLista[index].Id}; {SzerverData.GyorUserLista[index].Nev};{SzerverData.GyorUserLista[index].Jelszo} Győri felhasználó");
                }
                else
                {
                    MessageBox.Show("Nincs ilyen nevű felhasználó");
                }
            }
            else
            {
                MessageBox.Show("Írja be a keresendő felhasználónevet");
            }
        }
    }
}