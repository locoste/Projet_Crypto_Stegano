using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Message
    {
        private string message;
        private List<int> position;

        public Message(string message)
        {
            this.message = message;
            position = new List<int>(0);
        }

        public void set_position(int x, int y)
        {
            this.position.Add(x);
            this.position.Add(y);
        }

        public List<int> get_position()
        {
            return this.position;
        }

        public string get_message()
        {
            return this.message;
        }
    }
}
