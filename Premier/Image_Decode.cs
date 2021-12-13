using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Project
{
    class Image_Decode
    {
        private Bitmap image;

        public Image_Decode(Bitmap image)
        {
            this.image = image;
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

        private string decode_message(string message, int private_key, int n)
        {
            RSA_decode rsa_decode = new RSA_decode(private_key, n);
            return rsa_decode.decode_message(message);
        }
    }
}
