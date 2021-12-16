using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Message
    {
        private string message;
        private List<int> position;

        // Constructeur de la classe
        public Message(string message)
        {
            this.message = message;
            position = new List<int>(0);
        }

        /*
         * <summary>Cette fonction sauvegarde dans une liste les valeurs x, y , offset et multi</summary>
         * <param>int x: x</param>
         * <param>int y: y</param>
         * <param>int offset: offset</param>
         * <param>int multi: multi</param>
         */
        public void set_position(int x, int y, int offset, int multi)
        {
            this.position.Add(x);
            this.position.Add(y);
            this.position.Add(offset);
            this.position.Add(multi);
        }

        // getter de la liste pour une instance
        public List<int> get_position()
        {
            return this.position;
        }

        // getter pour le message d'une instance
        public string get_message()
        {
            return this.message;
        }
    }
}
