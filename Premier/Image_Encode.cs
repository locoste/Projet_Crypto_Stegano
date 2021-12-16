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

        /*
         * <summary>Fonction d'initialisation des messages et RSA</summary>
         */
        public void set_message(Message message)
        {
            this.message = message;
            this.initialize_rsa();
        }

        /*
        * <summary>Tant que la valeur de n est inférieur à 256 ou supérieur à 65 280 on refait un calcul des clef RSA. Un n < 256 ne permetrra pas de décoder tous les caractères (ex: 251 (sqrt()). 
        * Si n > 65 280, n ne pourra pas être caché dans l'image car la valeur sera trop grande</summary> 
        */
        public void initialize_rsa()
        {
            do
            {
                this.rsa = new RSA_Encode(256);
            } while (this.rsa.get_n() < 256 || this.rsa.get_n() > 65280);
        }

        /*
        * <summary>Pour chaque caractère, on stock les coordonnées xp, yp du pixel correspondant en haut à droite de l'image aux coordonnées x=image.Width -1 et y.
        * On stock ensuite la valeur de offset et multi en bas à gauche tel que x = 0 et y = image.Height - y. Une fois tous les caractères cachés, On stock la clef privé et le n 
        * de la meme façon. On fini l'encodage avec END sur les valeurs RGB en haut à droite comme idetificateur de fin de message.</summary> 
        */
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
        }


    /*
     *<summary>Pour chaque caractère chiffré avec RSA, On recherche le pixel dans lequel sera contenu l'information. On fini par appelé la fonction qui va
     *Caché les coordonnées et les offsets.</summary>
     */
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

        /*
         * <summary>Etant donné un caractère chiffré on trouve une valeur de R d'un pixel tel que:
         * lettre = R + offset + 256 * multi</summary>
         */
        private void get_point_position(int lettre)
        {
            // On initialise multi à truncate(lettre / 256) pour éviter de tourner dans les boucles sachant que la valeur de lettre est supérieur 
            // à 256
            for (int multi = (int)Math.Truncate((decimal)lettre / 256); multi < 256; multi++)
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

        // Renvoie les positions x, y , offset, multi de chaque lettre
        public List<int> get_position()
        {
            return this.message.get_position();
        }

        // renvoie l'image
        public Bitmap get_image()
        {
            return this.image;
        }

        // chiffre le message avec RSA pour le message de l'instance de la classe.
        private string encode_message()
        {
            return this.rsa.encode_message(this.message.get_message());
        }
    }
}
