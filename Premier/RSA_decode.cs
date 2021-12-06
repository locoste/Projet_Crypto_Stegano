using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Project
{
    class RSA_decode
    {
        private int n;
        private int private_key;

        public RSA_decode(int private_key, int n)
        {
            this.n = n;
            this.private_key = private_key;
        }

        public int get_n()
        {
            return this.n;
        }

        public int get_private_key()
        {
            return this.private_key;
        }

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
