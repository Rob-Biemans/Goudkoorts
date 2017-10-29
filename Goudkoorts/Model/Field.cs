using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Field : BaseField
    {

        public MoveAbleObject MoveAbleObject { get; set; }

        public override int Pos { get; set; }

        public override void Action(Game game) {}

        public override string Icon()
        {
            return "F";
        }

        public override bool ContainsMoveAbleObject()
        {
            if (this.MoveAbleObject != null)
                return true;

            return false;
        }

        override public bool PutMoveAbleObjectOnThisField(MoveAbleObject obj, Game game)
        {
            if (obj != null && this.MoveAbleObject == null) {
                this.MoveAbleObject = obj;
                this.MoveAbleObject.Pos = this.Pos;
                return true;
            } else {
               // Cart found!
               // Gameover
               game.setGameOver();
            }

            return false;
        }

        public override void RemoveMoveAbleObjectFromThisField(bool val)
        {
            if (this.MoveAbleObject != null && val == true) {
                this.MoveAbleObject = null;
            } else {
                // Theres no cart/ship to be removed.
            }
        }

        
    }
}