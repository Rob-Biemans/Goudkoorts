using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Player
    {
        private int score { get; set; }

        // Constructor
        public Player()
        {
            this.score = 0;
        }

        public int getScore()
        {
            return this.score;
        }

        public void increaseScore()
        {
            this.score += 10;
        }
    }
}