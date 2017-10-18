using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Player
    {
        private int score = 0;

        // Constructor
        public Player()
        {

        }

        public int getScore()
        {
            return this.score;
        }

        public void increaseScore()
        {
            this.score++;
        }
    }
}