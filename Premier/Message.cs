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

        public void set_position(int x, int y, int offset, int multi)
        {
            this.position.Add(x);
            this.position.Add(y);
            this.position.Add(offset);
            this.position.Add(multi);
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
