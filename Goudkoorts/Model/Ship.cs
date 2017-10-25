using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Ship : MoveAbleObject
    {
        // Declarations
        private int currentGold;
        private int maxGold = 8;

        // Constructor
        public Ship()
        {
            this.currentGold = 0;
        }

        public override string Icon()
        {
            return "0";
        }

        public int getCurrentAmountOfCarts()
        {
            return currentGold;
        }

        public void AddGoldToShip()
        {
            this.currentGold++;
        }
    }
}