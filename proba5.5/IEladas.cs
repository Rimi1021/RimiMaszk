using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba5._5
{
    interface IEladas
    {

        /*
        * A kosar event leirasa
        */
        void Kosarevent(TextBox kosatextbx, TextBox encode, TextBox decode, Label akcio, Label adottbrutto, Label adottbruttoakcio);


        void Manualishozzaadasgomb(string maszktipus, string maszknev, int max, int felvihetodb, TextBox textbxdb, ListBox kosar, Label osszesar, Label osszesbrutto);

        void Listboxelemektorles(ListBox listbx, Label osszesar, Label osszesbrutto, TextBox txtbxdb);


        void TermekHozzadas2(TextBox kosartxt, TextBox encode, TextBox decode, ListBox listbx, PictureBox picbox, Label adottbrutto, Label adottbruttoakcio, Label osszesar, Label osszesbrutto, Label akcio);

    }
}
