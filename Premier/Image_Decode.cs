using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Project
{
    class Image_Decode
    {
        private Bitmap image;

        // Constructeur de la classe.
        public Image_Decode(Bitmap image)
        {
            this.image = image;
        }

        /* 
         * <summary>Cette fonction recherche le message caché dans l'image.</summary>
         */
        public string search_message()
        {
            Boolean done = false;
            string message = "";
            int x = this.image.Width - 1;
            int y = 0;
            int private_key = 0;
            int n = 0;

            // tant que "done" est à False
            while (!done)
            {
                // si la valeur de y est égale à la hauteur de l'image celà signifie qu'aucun message n'est caché dans l'image.
                // on retourne donc la valeur null
                if (y + 1 == this.image.Height)
                {
                    return null;
                }
                // Si le prochain pixel contient l'information 'END', cela signifie que nous arrivons à la fin du message.
                // Ainsi, on récupère la clé privé et la valeur de n qui vont servir à déchiffrer le message.
                else if (Convert.ToChar((int)this.image.GetPixel(x, y + 1).R) == 'E' && Convert.ToChar((int)this.image.GetPixel(x, y + 1).G) == 'N' && Convert.ToChar((int)this.image.GetPixel(x, y + 1).B) == 'D')
                {
                    private_key = (int)this.image.GetPixel(x, y).R + (int)this.image.GetPixel(x, y).G * 256;
                    n = (int)this.image.GetPixel(0, this.image.Height - 1 - y).G + (int)this.image.GetPixel(0, this.image.Height - 1 - y).B * 256;
                    done = true;
                }
                // Cette fonction récupère les valeurs x, y, offset et multi pour obtenir la valeur du charactère encodé.
                // x, y étant caché en haut à  droite de l'image et offset, multi en bas à gauche. C = pixel(x, y).R + offset + 256 * multi
                else
                {
                    int r1 = this.image.GetPixel(x, y).R;
                    int g1 = this.image.GetPixel(x, y).G;
                    int r = this.image.GetPixel(r1, g1).R;
                    int offset = this.image.GetPixel(0, this.image.Height - 1 - y).R;
                    int multi = this.image.GetPixel(0, this.image.Height - 1 - y).G;
                    message += (r + 256 * multi + offset) + ",";
                    y++;
                }
            }
            // On enlève la dernière virgule du message
            message = message.Remove(message.Length - 1);

            // On envoie le message encodé avec la clé privé et n pour obtenir le message en clair.
            return this.decode_message(message, private_key, n);
        }

        /* 
         * <summary>Cette fonction créer une instance de RSA_decode et retourne le message déchiffré.</summary>
         * <param>string message: le message chiffré</param>
         * <param>int private_key: la valeur "d" de la clé privé</param>
         * <param>int n: La valeur n pour le déchiffrement</param>
         */
        private string decode_message(string message, int private_key, int n)
        {
            RSA_decode rsa_decode = new RSA_decode(private_key, n);
            return rsa_decode.decode_message(message);
        }
    }
}
