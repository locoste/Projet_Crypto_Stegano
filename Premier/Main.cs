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

        private void chiffrer_Click(object sender, EventArgs e)
        {
            var chiffrer = new Chiffrage();
            chiffrer.ShowDialog();
        }

        private void dechiffrer_Click(object sender, EventArgs e)
        {
            var dechiffrer = new Dechiffrer();
            dechiffrer.ShowDialog();
        }
    }
}
