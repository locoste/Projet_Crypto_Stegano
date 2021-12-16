using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /*
         * <summary>Cette fonction appel l'interface pour cacher un message dans une image</summary>
         */
        private void chiffrer_Click(object sender, EventArgs e)
        {
            var chiffrer = new Chiffrage();
            chiffrer.ShowDialog();
        }

        /*
         * <summary>Cette fonction appel l'interface pour déchiffrer un message à partir d'une image</summary>
         */
        private void dechiffrer_Click(object sender, EventArgs e)
        {
            var dechiffrer = new Dechiffrer();
            dechiffrer.ShowDialog();
        }
    }
}
