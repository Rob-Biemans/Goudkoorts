using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Ship : MoveAbleObject
    {
        // Declarations
        private int currentCarts;
        private int maxCarts = 8;

        // Constructor
        public Ship()
        {
            this.currentCarts = 0;
        }

        public override string Icon()
        {
            return "@";
        }

        public int getCurrentAmountOfCarts()
        {
            return currentCarts;
        }

        public void AddCartToShip()
        {
            this.currentCarts++;
        }
    }
}