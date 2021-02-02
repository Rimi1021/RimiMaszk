using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proba5._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_kilepes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan ki szeretne lépni?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close(); //Ha a „No” kattintunk, akkor nem csinálunk semmit, a feltétel miatt, ez persze lehet másik „gomb” is!
            }
            else
            {
                try
                {
                    //Alapértelmezetten az ablak bezáródna magától így azt külön nem kell kiadni, kivéve ha az eventet külön gombra tesszük.
                    //Ide jöhet az adatbázis mentése majd bezárása ha van!
                    //pl.: ABKezelo.KapcsolatBontasa();->Ebben van az SQL connection AdatbázisCsalakozas.Close();
                }
                catch
                {
                    return; //Nem csinálunk semmit csak visszatérünk az eredeti állapothoz.
                }
            }
        }

        private void button_Bejelentkezes_Click(object sender, EventArgs e)
        {
            if (radioButton_Debrecen2.Checked == false && radioButton_Gyor2.Checked == false &&
                radioButton_Admin2.Checked == false &&
                radioButton_Budapest2.Checked == false)
            {
                MessageBox.Show("Válassza ki a megfelelő jogosultságot");
            }
            else
            {
                ///////////// AdminRadibutton
                if (radioButton_Admin2.Checked == true)
                {
                    ListakbaOlvasas.AdminListabaOlvasas();
                    int index = 0;
                    bool vane = false;
                    bool vanejlszo = false;
                    for (int i = 0; i < SzerverData.AdminUserLista.Count; i++)
                    {
                        if (textBox_nev.Text == SzerverData.AdminUserLista[i].Nev)
                        {
                            index = i;
                            vane = true;
                        }
                    }
                    if (vane == true)
                    {
                        for (int i = 0; i < SzerverData.AdminUserLista.Count; i++)
                        {
                            if (textBox_jelszo.Text == SzerverData.AdminUserLista[index].Jelszo)
                            {
                                vanejlszo = true;
                            }
                        }
                    }
                    if (vane == true && vanejlszo == true)
                    {
                        Admin AdminForm = new Admin();
                        this.Hide();
                        AdminForm.Show();
                        AdminForm.BringToFront();
                    }
                    else
                    {
                        if (MessageBox.Show("Kérem ellenőrizze le újból a belépési adatait", "Hibás felhasználónév vagy jelszó", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
                ///////////////////Budapest RadioButton
                /*if (radioButton_Budapest2.Checked == true)
                {
                    ListakbaOlvasas.AdminListabaOlvasas();
                    int index = 0;
                    bool vane = false;
                    bool vanejlszo = false;
                    for (int i = 0; i < SzerverData.AdminUserLista.Count; i++)
                    {
                        if (textBox_nev.Text == SzerverData.AdminUserLista[i].Nev)
                        {
                            index = i;
                            vane = true;
                        }
                    }
                    if (vane == true)
                    {
                        for (int i = 0; i < SzerverData.AdminUserLista.Count; i++)
                        {
                            if (textBox_jelszo.Text == SzerverData.AdminUserLista[index].Jelszo)
                            {
                                vanejlszo = true;
                            }
                        }
                    }
                    if (vane == true && vanejlszo == true)
                    {
                        Admin AdminForm = new Admin();
                        this.Hide();
                        AdminForm.Show();
                        AdminForm.BringToFront();
                    }
                    else
                    {
                        if (MessageBox.Show("Kérem ellenőrizze le újból a belépési adatait", "Hibás felhasználónév vagy jelszó", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }*/
            }
        }
    }
}
