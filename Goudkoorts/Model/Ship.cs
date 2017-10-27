using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Ship : MoveAbleObject
    {
        // Declarations
        private int currentGold { get; set; }

        private int maxGold = 8;

        // Constructor
        public Ship()
        {
            this.currentGold = 0;
        }

        public override string Icon()
        {
            return currentGold.ToString();
        }

        public int getCurrentAmountOfCarts()
        {
            return currentGold;
        }

        public void AddGoldToShip()
        {
            this.currentGold++;
        }

        public override bool Move()
        {

            if (IsAtDock() && this.currentGold < maxGold)
                return false;

            return true;
        }

        public bool IsAtDock()
        {
            if (this.Pos == 8)
                return true;

            return false;
        }
    }
}