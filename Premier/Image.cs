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
    public partial class Image : Form
    {

        private Bitmap encoded_image;

        public Image()
        {
            InitializeComponent();
        }

        private void get_image_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    System.Drawing.Image image1 = System.Drawing.Image.FromFile(filePath);
                    this.file_name.Text = filePath;

                    this.pictureBox1.Image = image1;

                    this.encoded_image = new Bitmap(image1);

                    this.set_layout_image(image1);

                    using (StreamWriter sw = File.AppendText(@"C:\\Users\\louis\\OneDrive\\Documents\\Master2\\programmation\\pixel_image_message.txt"))
                    {
                        for (int j = 0; j < this.encoded_image.Height; j++)
                        {
                            string pixels = "";
                            for (int i = 0; i < this.encoded_image.Width; i++)
                            {
                                pixels += this.encoded_image.GetPixel(i, j).A + ", " + this.encoded_image.GetPixel(i, j).R + ", " + this.encoded_image.GetPixel(i, j).G + ", " + this.encoded_image.GetPixel(i, j).B + "| ";
                            }
                            pixels += "END OF LINE| ";
                            sw.Write(pixels);
                        }
                    }
                }
            }
        }

        private void set_layout_image(System.Drawing.Image image1)
        {
            this.pictureBox1.Width = image1.Width;
            this.pictureBox1.Height = image1.Height;

            this.message_hide_label.Location = new Point(this.pictureBox1.Location.X + this.pictureBox1.Width + 50, this.message_hide_label.Location.Y);
            this.message_to_hide.Location = new Point(this.pictureBox1.Location.X + this.pictureBox1.Width + 50, this.message_to_hide.Location.Y);

            this.hide_message.Location = new Point(this.pictureBox1.Location.X + this.pictureBox1.Width + 50, this.hide_message.Location.Y);

            this.code_carac.Location = new Point(this.pictureBox1.Location.X + this.pictureBox1.Width + 50, this.code_carac.Location.Y);
            this.get_message.Location = new Point(this.pictureBox1.Location.X + this.pictureBox1.Width + 50, this.get_message.Location.Y);
            this.message.Location = new Point(this.pictureBox1.Location.X + this.pictureBox1.Width + 50, this.message.Location.Y);
        }

        private void hide_message_Click(object sender, EventArgs e)
        {
            Message message = new Message(this.message_to_hide.Text);

            if (this.pictureBox1.Image != null)
            {
                Bitmap imagebmp = new Bitmap(this.pictureBox1.Image);
                BM_image bmimage = new BM_image(imagebmp);

                bmimage.set_message(message);

                bmimage.hide_message_better();

                this.encoded_image = bmimage.get_image();

                this.pictureBox1.Image = bmimage.get_image();

                /* Bitmap image = bmimage.get_image();

                 using (StreamWriter sw = File.AppendText(@"C:\\Users\\louis\\OneDrive\\Documents\\Master2\\programmation\\pixel.txt"))
                 {
                     for (int j = 0; j < image.Height; j++)
                     {
                         string pixels = "";
                         for (int i = 0; i < image.Width; i++)
                         {
                             pixels += image.GetPixel(i, j).R + ", " + image.GetPixel(i, j).G + ", " + image.GetPixel(i, j).B + "|";
                         }
                         pixels += "END OF LINE";
                         sw.Write(pixels);
                     }
                 }*/

                System.Drawing.Bitmap image2 = this.encoded_image;
                using (StreamWriter sw = File.AppendText(@"C:\\Users\\louis\\OneDrive\\Documents\\Master2\\programmation\\pixel2.txt"))
                {
                    for (int j = 0; j < image2.Height; j++)
                    {
                        string pixels = "";
                        for (int i = 0; i < image2.Width; i++)
                        {
                            pixels += image2.GetPixel(i, j).A + ", " + image2.GetPixel(i, j).R + ", " + image2.GetPixel(i, j).G + ", " + image2.GetPixel(i, j).B + "| ";
                        }
                        pixels += "END OF LINE| ";
                        sw.Write(pixels);
                    }
                }

                this.code_carac.Text = "";
                foreach(int pos in bmimage.get_position())
                {
                    this.code_carac.Text += pos.ToString() + " ";
                }
            }
        }

        private void get_message_Click(object sender, EventArgs e)
        {
            BM_image bmimage = new BM_image(this.encoded_image);

            string message = bmimage.search_message_better();

            this.message.Text = message;
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
                    //Bitmap image_to_save = new Bitmap(this.encoded_image, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    Bitmap clone = new Bitmap(this.encoded_image.Width, this.encoded_image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                    using (Graphics gr = Graphics.FromImage(clone))
                    {
                        gr.DrawImage(this.encoded_image, new Rectangle(0, 0, clone.Width, clone.Height));
                    }
                    clone.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                    //this.encoded_image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                    fs.Close();
                }
            }
        }
    }
}
