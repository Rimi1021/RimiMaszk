using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (checkBox_Adminuserek.Checked == true)
            {
                ListakbaOlvasas.AdminListabaOlvasas();
                for (int i = 0; i < SzerverData.AdminUserLista.Count; i++)
                {
                    listBox_Felhasznalolistazas.Items.Add(SzerverData.AdminUserLista[i].Id+"; "+ SzerverData.AdminUserLista[i].Nev+"; "+ SzerverData.AdminUserLista[i].Jelszo);
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
            else if (checkBox_Debuserek.Checked == false && checkBox_Gyoruserek.Checked == false && checkBox_BPuserek.Checked == false && checkBox_Adminuserek.Checked == false)
            {
                if (MessageBox.Show("A listázás sikertelen", "Nincs kijelölt checkbox", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    return;
                }
            }       
        }
    }
}
