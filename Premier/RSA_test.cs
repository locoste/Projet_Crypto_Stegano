using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class RSA_test : Form
    {
        private RSA rsa;

        public RSA_test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            do
            {
                this.rsa = new RSA(Convert.ToInt32(this.nb_premier.Value));
            } while (this.rsa.get_n() < 256);

            this.public_key.Text = "(" + rsa.get_static_public_key()[0].ToString() + ", " + rsa.get_static_public_key()[1].ToString() + ")";
            this.private_key.Text = rsa.get_private_key().ToString();
        }

        private void get_rsa_button_Click(object sender, EventArgs e)
        {
            this.code_ascii.Text = "";
            foreach (char lettre in this.message_to_encode.Text)
            {
                this.code_ascii.Text += Convert.ToInt32(lettre) + ",";
            }
            this.rsa_code.Text = this.rsa.encode_message(this.message_to_encode.Text);
        }

        private void get_message_button_Click(object sender, EventArgs e)
        {
            this.message.Text = rsa.decode_message(this.rsa_code.Text);
        }
    }
}
