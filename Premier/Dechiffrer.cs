using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Dechiffrer : Form
    {
        
        private Bitmap encoded_image;
        public Dechiffrer()
        {
            InitializeComponent();
        }

        /* 
         * <summary>Cette fonction est appelé pour charger l'image encodé dans l'interface. 
         * Elle est affiché et sauvegarder dans l'attribut "encoded_image" de la classe.</summary>
         */
        private void ouvrir_image_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    System.Drawing.Image image1 = System.Drawing.Image.FromFile(filePath);

                    this.Image_encode.Image = image1;

                    this.encoded_image = new Bitmap(image1);
                }
            }
        }

        /* 
         * <summary>Cette fonction déchiffre le message dans l'image. Elle crée une nouvelle instance de la classe et cherche le message caché dedans.
         * Si la fonction renvoie null c'est qu'aucun message n'est présent dans l'image et il affiche alors "Il n'y a aucun message dans cette image".
         * Sinon, le message est affiché.</summary>
         */
        private void dechiffrer_button_Click(object sender, EventArgs e)
        {
            Image_Decode img_decode = new Image_Decode(this.encoded_image);

            string message = img_decode.search_message();
            if (message == null)
            {
                this.message.Text = "Il n'y a aucun message dans cette image";
            } else
            {
                this.message.Text = message;
            }
        }
    }
}
