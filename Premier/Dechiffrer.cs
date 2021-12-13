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

        private void dechiffrer_button_Click(object sender, EventArgs e)
        {
            Image_Decode img_decode = new Image_Decode(this.encoded_image);

            string message = img_decode.search_message_better();

            this.message.Text = message;
        }
    }
}
