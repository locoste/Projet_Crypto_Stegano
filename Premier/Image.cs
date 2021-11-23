using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Image : Form
    {

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

                    this.set_layout_image(image1);
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

                this.pictureBox1.Image = bmimage.get_image();

                this.code_carac.Text = "";
                foreach(int pos in bmimage.get_position())
                {
                    this.code_carac.Text += pos.ToString() + " ";
                }
                this.code_carac.Text += ", (" + bmimage.get_image().Width + ", " + bmimage.get_image().Height + ")";
            }
        }

        private void get_message_Click(object sender, EventArgs e)
        {
            BM_image bmimage = new BM_image(new Bitmap(this.pictureBox1.Image));

            string message = bmimage.search_message_better();

            this.message.Text = message;
        }
    }
}
