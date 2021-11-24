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

        public BM_image(Bitmap image)
        {
            this.image = image;
        }

        public void set_message(Message message)
        {
            this.message = message;
        }

        public void hide_message()
        {
            char[] charArr = this.message.get_message().ToCharArray();
            for (int i = 2; i < charArr.Length; i += 3)
            {
                this.change_byte(Convert.ToInt32(charArr[i - 2]), Convert.ToInt32(charArr[i - 1]), Convert.ToInt32(charArr[i]));
            }
            if (charArr.Length % 3 == 1)
            {
                this.change_byte(Convert.ToInt32(charArr[charArr.Length - 1]));
            } else if (charArr.Length % 3 == 2)
            {
                this.change_byte(Convert.ToInt32(charArr[charArr.Length - 2]), Convert.ToInt32(charArr[charArr.Length - 1]));
            }
        }

        private void hide_position()
        {
            System.Drawing.Imaging.BitmapData bmpData = this.image.LockBits(new Rectangle(0, 0, this.image.Width, this.image.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite,
            this.image.PixelFormat);

            bmpData.Stride -= 1;

            this.image.UnlockBits(bmpData);

            List<int> position = this.get_position();

            int x = this.image.Width - 1;
            int y = 0;
            Random rand = new Random();
            for (int i = 2; i < position.Count; i+=3)
            {
                this.image.SetPixel(x, y, Color.FromArgb(position[i - 2], position[i - 1], position[i]));
                y++;
            }
            this.image.SetPixel(x, y, Color.FromArgb(Convert.ToInt32('E'), Convert.ToInt32('N'), Convert.ToInt32('D')));
        }

        public void hide_message_better()
        {
            char[] charArr = this.message.get_message().ToCharArray();
            foreach(char lettre in charArr)
            {
                this.get_point_position(Convert.ToInt32(lettre));
            }
            this.hide_position();
        }

        private void get_point_position(int lettre)
        {
            int offset = 0;
            bool done = false;
            while (true)
            {
                for (int x = 0; x < this.image.Width; x++)
                {
                    for (int y = 0; y < this.image.Height; y++)
                    {
                        if (this.image.GetPixel(x, y).R == lettre + offset)
                        {
                            this.message.set_position(x, y, offset);
                            return;
                        }
                    }
                }
                offset++;
            }
        }

        private void change_byte(int l1, int l2 = 0, int l3 = 0)
        {
            int x = 1078 % this.image.Width + message.get_position().Count / 3;
            int y = 10;
            this.image.SetPixel(x, y, Color.FromArgb(l1, l2, l3));
            this.message.set_position(x, y, 0);
        }

        public List<int> get_position()
        {
            return message.get_position();
        }

        public string search_message()
        {
            int x = 1078 % this.image.Width;
            int y = 10;
            Color pixel1 = this.image.GetPixel(x, y);
            Color pixel2 = this.image.GetPixel(x+1, y);
            return Convert.ToChar(pixel1.R).ToString()+ Convert.ToChar(pixel1.G).ToString()+ Convert.ToChar(pixel1.B).ToString() + Convert.ToChar(pixel2.R).ToString() + Convert.ToChar(pixel2.G).ToString() + Convert.ToChar(pixel2.B).ToString();
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
            while (!done)
            {
                // get pixel
                if (Convert.ToChar((int)this.image.GetPixel(x, y).R) == 'E' && Convert.ToChar((int)this.image.GetPixel(x, y).G) == 'N' && Convert.ToChar((int)this.image.GetPixel(x, y).B) == 'D')
                {
                    done = true;
                } else
                {
                    int r = (int)this.image.GetPixel(x, y).R;
                    int g = (int)this.image.GetPixel(x, y).G;
                    int b = (int)this.image.GetPixel(x, y).B;
                    int car = this.image.GetPixel((int)this.image.GetPixel(x, y).R, (int)this.image.GetPixel(x, y).G).R;
                    message += Convert.ToChar(this.image.GetPixel((int)this.image.GetPixel(x, y).R, (int)this.image.GetPixel(x, y).G).R + (int)this.image.GetPixel(x, y).B) + ", ";
                    y++;
                }
            }
            return message;
        }
    }
}
