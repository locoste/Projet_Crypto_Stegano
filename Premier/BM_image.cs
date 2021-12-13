using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Project
{
    class BM_image
    {
        private Bitmap image;
        private Message message;
        private RSA rsa;

        public BM_image(Bitmap image)
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
                this.rsa = new RSA(100);
            } while (this.rsa.get_n() < 256 || this.rsa.get_n() > 512);
        } 

        private void hide_position()
        {
            List<int> position = this.get_position();

            int x = this.image.Width - 1;
            int y = 0;
            Random rand = new Random();
            for (int i = 3; i < position.Count; i+=4)
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

        private void hide_position_v2()
        {
            int x = 0;
            int y = 0;
            List<int> position = this.get_position();
            string binary_position = "";
            for(int i = 3; i<position.Count; i += 4)
            {
                binary_position += ConvertToByteArray(position[i - 3].ToString(), Encoding.ASCII).ToString();
                binary_position += ConvertToByteArray(",", Encoding.ASCII).ToString();
                binary_position += ConvertToByteArray(position[i - 2].ToString(), Encoding.ASCII).ToString();
                binary_position += ConvertToByteArray(",", Encoding.ASCII).ToString();
                binary_position += ConvertToByteArray(position[i - 1].ToString(), Encoding.ASCII).ToString();
                binary_position += ConvertToByteArray(",", Encoding.ASCII).ToString();
                binary_position += ConvertToByteArray(position[i].ToString(), Encoding.ASCII).ToString();
                binary_position += ConvertToByteArray("E", Encoding.ASCII).ToString();
                y++;
            }
            //this.image.SetPixel(x, y, Color.FromArgb(Convert.ToInt32('E'), Convert.ToInt32('N'), Convert.ToInt32('D')));
             
        }

        public static byte[] ConvertToByteArray(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
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

        public string search_message_better()
        {
            Boolean done = false;
            string message = "";
            int x = this.image.Width - 1;
            int y = 0;
            int private_key = 0;
            int n = 0;
            while (!done)
            {
                if (Convert.ToChar((int)this.image.GetPixel(x, y + 1).R) == 'E' && Convert.ToChar((int)this.image.GetPixel(x, y + 1).G) == 'N' && Convert.ToChar((int)this.image.GetPixel(x, y + 1).B) == 'D')
                {
                    private_key = (int)this.image.GetPixel(x, y).R + (int)this.image.GetPixel(x, y).G * 256;
                    n = (int)this.image.GetPixel(0, this.image.Height - 1 - y).G + (int)this.image.GetPixel(0, this.image.Height - 1 - y).B * 256;
                    done = true;
                }
                else
                {
                    int r1 = this.image.GetPixel(x, y).R;
                    int g1 = this.image.GetPixel(x, y).G;
                    int r = this.image.GetPixel(r1, g1).R;
                    int a = this.image.GetPixel(0, this.image.Height - 1 - y).R;
                    int b = this.image.GetPixel(0, this.image.Height - 1 - y).G;
                    message += (r + 256 * b + a) + ",";
                    y++;
                }
            }
            message = message.Remove(message.Length - 1);
            return this.decode_message(message, private_key, n);
        }

        private string encode_message()
        {
            return this.rsa.encode_message(this.message.get_message());
        }

        private string decode_message(string message, int private_key, int n)
        {
            RSA_decode rsa_decode = new RSA_decode(private_key, n);
            return rsa_decode.decode_message(message);
        }
    }
}
