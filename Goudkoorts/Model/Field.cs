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

        public override void Action(Game game)
        {

        }

        public override bool ContainsMoveAbleObject()
        {
            if (this.MoveAbleObject != null)
                return true;

            return false;
        }

        public override string Icon()
        {
            return "F";
        }

        override public void PutMoveAbleObjectOnThisField(MoveAbleObject obj)
        {
            if (obj != null && this.MoveAbleObject == null) {
                this.MoveAbleObject = obj;
                this.MoveAbleObject.Pos = this.Pos;
            } else {
                // Cart found!
                // Gameover
               // game.setGameOver();
            }
        }

        public override void RemoveMoveAbleObjectFromThisField()
        {
            if (this.MoveAbleObject != null) {
                this.MoveAbleObject = null;
            } else {
                // Theres no cart/ship to be removed.
            }
        }

        
    }
}