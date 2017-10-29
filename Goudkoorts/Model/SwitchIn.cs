using System;
using System.Linq;

namespace Goudkoorts
{
    public class SwitchIn : Switch
    {

        public SwitchIn(string value)
        {
            this.icon = value;
            this.direction = Directions.Down;
        }

        public override Directions getDirection()
        {
            return this.direction;
        }

        public override string Icon()
        {
            return this.icon;
        }

        public override void changeDirection()
        {
            var lastDirection = Enum.GetValues(typeof(Directions)).Cast<Directions>().Last();

            if (direction == lastDirection) {
                this.direction--;
                this.icon = "╰";
            } else {
                this.direction++;
                this.icon = "╭";
            }

        }

        public override bool PutMoveAbleObjectOnThisField(MoveAbleObject obj, Game game)
        {

            if (this.direction == Directions.Down && this.Pos < obj.Pos ||
                this.direction == Directions.Up && this.Pos > obj.Pos)
            {
                this.MoveAbleObject = obj;
                this.MoveAbleObject.Pos = this.Pos;
                return true;
            }

            return false;
        }

    }
}