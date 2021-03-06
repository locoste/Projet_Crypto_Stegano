using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Project
{
    class RSA_Encode:RSA
    {
        private int p;
        private int q;

        private int n;
        private int phi;
        private int e;

        private int private_key;

        private List<int> public_key;

        private static Premier premier;

        /*
         * <summary>Constructeur de la classe RSA_Encode. Celui-ci récupère une liste de nombre premier et initialise les clés public et privé.</summary>
         * <param>int nb: la valeur maximum des chiffres premier</param>
         */
        public RSA_Encode(int nb)
        {
            premier = Premier.getInstance();
            premier.set_premier(nb);
            this.public_key = new List<int>(2);
            this.set_public_key();
            this.set_private_key();
        }

        /*
        * <summary>Fonction de génération de clef publique. On selctionne aléatoirement p et q dans la liste de nombre premier. On calcul n tel que n = q*p. On fini par appeler la fonction set_phi() pour 
        * calculer phi. </summary> 
        */
        public void set_public_key()
        {
            List<int> list_premier = premier.get_premier();
            var rand = new Random();
            this.q = list_premier[rand.Next(list_premier.Count)];
            this.p = list_premier[rand.Next(list_premier.Count)];


            this.n = this.p * this.q;
            this.set_phi();

            this.public_key = this.get_public_key(list_premier);
        }

        /*
         * <summary>Generate private key with public key values. Il faut trouver une valeur de d tel que e * d % phi = 1 </summary> 
         */
        public void set_private_key()
        {
            int reste = 0;
            int d = 0;
            while (reste != 1)
            {
                d++;
                reste = (this.public_key[0] * d) % this.phi;
            }
            this.private_key = d;
        }

        /*
        * <summary>Fonction getter pour la clef privé</summary> 
        */
        public long get_private_key()
        {
            return this.private_key;
        }

        /*
        * <summary>Fonction getter pour n</summary> 
        */
        public int get_n()
        {
            return this.n;
        }

        /*
        * <summary>Fonction setter de phi tel que phi = (p-1) * (q-1)</summary> 
        */
        public void set_phi()
        {
            this.phi = (this.p - 1) * (this.q - 1);
        }

        /*
        * <summary>Fonction getter pour phi</summary> 
        */
        public int get_phi()
        {
            return phi;
        }

        /*
        * <summary>Initialisation de la clef public. Pour cela on va selectionner un nombre premier étant le plus grand diviseur commun avec phi</summary>
        * <param>List<int> list_premier: liste de nombre premier</param>
        */
        public List<int> get_public_key(List<int> list_premier)
        {
            List<int> nb_pgcd = new List<int>();
            var rand = new Random();

            foreach (int nb in list_premier)
            {
                if (this.pgcd(nb, this.phi) == 1)
                {
                    nb_pgcd.Add(nb);
                }
            }
            this.e = nb_pgcd[rand.Next(nb_pgcd.Count)];
            this.public_key.Add(this.e);
            this.public_key.Add(this.n);
            return public_key;
        }

        /*
        * <summary>Fonction getter pour la clef public</summary> 
        */
        public List<int> get_static_public_key()
        {
            return this.public_key;
        }

        /*
        * <summary>Fonction PGCD récursive. </summary>
        * <param>int a: nombre a</param>
        * <param>int b: nombre b</param>
        */
        public int pgcd(int a, int b)
        {
            int temp = a % b;
            if (temp == 0)
            {
                return b;
            }
            return pgcd(b, temp);
        }

        /*
        * <summary>Fonction d'encodage. Chaque lettre sera encodé selon l'équation: C = M^e mod N.</summary> 
        * <param>string message: le message à encoder</param>
        */
        public string encode_message(String message)
        {
            string encode_message = "";
            foreach (char lettre in message)
            {
                encode_message += BigInteger.ModPow(Convert.ToInt32(lettre), this.e, this.n).ToString();
                encode_message += ",";
            }
            // On retire la dernière virgule sinon l'appli va essayé de décoder une chaine vide.
            encode_message = encode_message.Remove(encode_message.Length - 1);
            return encode_message;
        }
    }
}
