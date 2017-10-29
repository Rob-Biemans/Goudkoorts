using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public class Yard : ActionField
    {
        public override string Icon()
        {
            return "Y";
        }

        public override bool PutMoveAbleObjectOnThisField(MoveAbleObject obj, Game game)
        {

            if (obj != null && this.MoveAbleObject == null && this.Next != null)
            {
                this.MoveAbleObject = obj;
                this.MoveAbleObject.Pos = this.Pos;
                return true;
            }

            return false;
        }
    }
}