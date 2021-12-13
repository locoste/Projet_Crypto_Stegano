using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Chiffrage : Form
    {

        private Bitmap encoded_image;
        public Chiffrage()
        {
            InitializeComponent();
        }

        private void cacher_message_Click(object sender, EventArgs e)
        {
            Message message = new Message(this.message_to_hide.Text);

            if (this.image_a_chiffrer.Image != null)
            {
                Bitmap imagebmp = new Bitmap(this.image_a_chiffrer.Image);
                Image_Encode img_encode = new Image_Encode(imagebmp);

                img_encode.set_message(message);

                img_encode.hide_message_better();

                this.encoded_image = img_encode.get_image();

                this.image_a_chiffrer.Image = img_encode.get_image();

            }
        }

        private void send_mail_Click(object sender, EventArgs e)
        {

        }

        private void charger_image_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    System.Drawing.Image image1 = System.Drawing.Image.FromFile(filePath);

                    this.image_a_chiffrer.Image = image1;

                    this.encoded_image = new Bitmap(image1);
                }
            }
        }

        private void save_image_Click(object sender, EventArgs e)
        {
            if (this.encoded_image != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Bitmap Image|*.bmp";

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = (FileStream)saveFileDialog1.OpenFile();

                    Bitmap clone = new Bitmap(this.encoded_image.Width, this.encoded_image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                    using (Graphics gr = Graphics.FromImage(clone))
                    {
                        gr.DrawImage(this.encoded_image, new Rectangle(0, 0, clone.Width, clone.Height));
                    }
                    clone.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                    fs.Close();
                }
            }
        }

        private void get_txt_button_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    string text = System.IO.File.ReadAllText(filePath);
                    this.message_to_hide.Text = text;
                }
            }
        }
    }
}
