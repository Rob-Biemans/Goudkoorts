using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Ship : moveAbleObject
    {
        // Declarations
        private int currentCarts;
        private int maxCarts = 8;

        // Constructor
        public Ship()
        {

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