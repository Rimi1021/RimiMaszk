﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba5._5
{
    public partial class BudapestForm : Form
    {
        public BudapestForm()
        {
            InitializeComponent();
            Nev(label_Nev);
        }
        public static void Nev(Label nev)
        {
            nev.Text = Form1.profilnev;
        }

        private void button_Kilepes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan ki szeretne lépni?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close(); //Ha a „No” kattintunk, akkor nem csinálunk semmit, a feltétel miatt, ez persze lehet másik „gomb” is!
            }
            else
            {
                return;
            }
        }

        private void button_Kijelentkezes_Click(object sender, EventArgs e)
        {
            Form1 Bejelentkezes = new Form1();
            this.Hide();
            Bejelentkezes.Show();
            Bejelentkezes.BringToFront();
        }
    }
}
