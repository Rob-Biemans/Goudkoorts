using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Field : BaseField
    {

        public MoveAbleObject MoveAbleObject { get; set; }

        public override string Icon()
        {
            return "F";
        }

        public void move()
        {
            if (this.Next == null)
            {
                // Einde van de track/water
                //this.RemoveMoveAbleObjectFromThisField();
            }
            else
            {
                this.Next.PutMoveAbleObjectOnThisField(this.MoveAbleObject);
                this.RemoveMoveAbleObjectFromThisField();
            }

        }

        override public void PutMoveAbleObjectOnThisField(MoveAbleObject obj)
        {
            if (obj != null) {
                this.MoveAbleObject = obj;
            } else {
                // Er is al aan cart
                // Gameover
                //Console.WriteLine("GAMEOVER");
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