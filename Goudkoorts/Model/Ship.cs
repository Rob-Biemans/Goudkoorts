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

        public bool CheckMove()
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

        public override void move(Game game)
        {
            LinkedList<Field> field = game.getGameField();
            BaseField _field = field.ElementAt(this.Pos);

            if (_field.Next == null)
            {
                game.getPlayer().increaseScore();

                _field.RemoveMoveAbleObjectFromThisField();
            }
            else if (field.ElementAt(this.Pos+1).MoveAbleObject != null)
            {
                
            } else if (CheckMove() == true)
            {
                _field.Next.PutMoveAbleObjectOnThisField(this);
                _field.RemoveMoveAbleObjectFromThisField();
            }
        }
    }
}