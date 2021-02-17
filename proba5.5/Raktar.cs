using System;
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
    public partial class Raktar : UserControl
    {
        public Raktar()
        {
            InitializeComponent();
        }
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
        /// HIBA!!! Ha A textboxba beleírunk majd kitöröljük az adatot HIBÁS feltételt kapunk
        /// </summary>
        
        //1.Sor
        private void button_1_1plusz_Click(object sender, EventArgs e)
        {
            szam1++;
            textBox_1_1.Text = Convert.ToString(szam1);
        }
        private void darabszamvaltozas(object sender, EventArgs e)
        {
            if (textBox_1_1.Text == "")
            {
                szam1 = 0;
            }
            else
            {
                szam1 = Convert.ToInt32(textBox_1_1.Text);
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
            if (textBox_2_2.Text == "")
            {
                szam2 = 0;
            }
            else
            {
                szam2 = Convert.ToInt32(textBox_2_2.Text);
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
            if (textBox_3_3.Text == "")
            {
                szam3 = 0;
            }
            else
            {
                szam3 = Convert.ToInt32(textBox_3_3.Text);
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
            if (textBox_4_4.Text == "")
            {
                szam4 = 0;
            }
            else
            {
                szam4 = Convert.ToInt32(textBox_4_4.Text);
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
            if (textBox_5_5.Text == "")
            {
                szam5 = 0;
            }
            else
            {
                szam5 = Convert.ToInt32(textBox_5_5.Text);
            }
        }

        //5.Sor
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
            if (textBox_6_6.Text == "")
            {
                szam6 = 0;
            }
            else
            {
                szam6 = Convert.ToInt32(textBox_6_6.Text);
            }
        }

        /// <summary>
        /// + -  Gombok és textbocChangek Vége
        /// /// </summary>
    }
}
