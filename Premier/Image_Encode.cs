using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Project
{
    class Image_Encode
    {
        private Bitmap image;
        private Message message;
        private RSA_Encode rsa;

        public Image_Encode(Bitmap image)
        {
            this.image = image;
        }

        public void set_message(Message message)
        {
            this.message = message;
            this.initialize_rsa();
        }

        public void initialize_rsa()
        {
            do
            {
                this.rsa = new RSA_Encode(100);
            } while (this.rsa.get_n() < 256 || this.rsa.get_n() > 512);
        }

        private void hide_position()
        {
            List<int> position = this.get_position();

            int x = this.image.Width - 1;
            int y = 0;
            Random rand = new Random();
            for (int i = 3; i < position.Count; i += 4)
            {
                this.image.SetPixel(x, y, Color.FromArgb(position[i - 3], position[i - 2], this.image.GetPixel(x, y).B));
                this.image.SetPixel(0, this.image.Height - 1 - y, Color.FromArgb(position[i - 1], position[i], this.image.GetPixel(0, this.image.Height - 1 - y).B));
                y++;
            }
            this.image.SetPixel(x, y, Color.FromArgb((int)this.rsa.get_private_key() % 256, (int)Math.Truncate((decimal)this.rsa.get_private_key() / 256), this.image.GetPixel(x, y).B));
            this.image.SetPixel(0, this.image.Height - 1 - y, Color.FromArgb(this.image.GetPixel(0, this.image.Height - 1 - y).R, (int)this.rsa.get_n() % 256, (int)Math.Truncate((decimal)this.rsa.get_n() / 256)));
            y++;
            this.image.SetPixel(x, y, Color.FromArgb(Convert.ToInt32('E'), Convert.ToInt32('N'), Convert.ToInt32('D')));
            //hide_position_v2();
        }


        public void hide_message_better()
        {
            string message_encode = this.encode_message();
            string[] encode = message_encode.Split(',');
            foreach (string code in encode)
            {
                this.get_point_position(int.Parse(code));
            }
            this.hide_position();

        }

        private void get_point_position(int lettre)
        {
            //int offset = Math.Max(0, lettre - 256);

            for (int multi = 0; multi < 256; multi++)
            {
                int offset = 0;
                while (offset < 256)
                {
                    for (int x = 0; x < 255; x++)
                    {
                        for (int y = 0; y < 255; y++)
                        {
                            int r = (int)this.image.GetPixel(x, y).R;
                            if ((int)this.image.GetPixel(x, y).R + offset + (256 * multi) == lettre)
                            {
                                this.message.set_position(x, y, offset, multi);
                                return;
                            }
                        }
                    }
                    offset++;
                }
            }
        }

        public List<int> get_position()
        {
            return this.message.get_position();
        }

        public Bitmap get_image()
        {
            return this.image;
        }

        private string encode_message()
        {
            return this.rsa.encode_message(this.message.get_message());
        }
    }
}
