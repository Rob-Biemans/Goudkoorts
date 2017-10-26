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

    }
}