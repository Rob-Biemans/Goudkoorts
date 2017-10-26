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

        public Dock _dock { get; set; }

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
            // Als het niet aan de dock ligt dan mag je bewegen
                // wel aan de dock? dan moet je 8 gold hebben

            // Als het 8 gold heeft en aan de dock zit, mag je weer moven
            if (this.currentGold == 8) {
                return true;
            }

            return true;
        }
    }
}