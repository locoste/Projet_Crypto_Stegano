using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Project
{
    class RSA_decode:RSA
    {
        private int n;
        private int private_key;

        /* Constructeur de la classe
         * <param>int private_key: valeur d pour dechiffrer</param>
         * <param>int n: valeur n pour le modulo </param>
         */
        public RSA_decode(int private_key, int n)
        {
            this.n = n;
            this.private_key = private_key;
        }

        // getter de n
        public int get_n()
        {
            return this.n;
        }

        // getter de d
        public int get_private_key()
        {
            return this.private_key;
        }

        /*
         * <summary>Pour chaque caractère chiffré on le décode tel que M = c^d mod n</summary>
         */
        public string decode_message(string message)
        {
            string decode_message = "";
            string[] subs = message.Split(',');
            foreach (string code in subs)
            {
                decode_message += Convert.ToChar((int)BigInteger.ModPow(int.Parse(code), this.private_key, this.n));
            }
            return decode_message;
        }
    }
}
