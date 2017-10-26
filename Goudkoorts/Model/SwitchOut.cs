using System;
using System.Linq;

namespace Goudkoorts
{
    public class SwitchOut : Switch
    {

        public SwitchOut(string value)
        {
            this.icon = value;
            this.direction = Directions.Down;
        }

        public override string Icon()
        {
            return this.icon;
        }

        public override Directions getDirection()
        {
            return this.direction;
        }

        public override void changeDirection()
        {
            var lastDirection = Enum.GetValues(typeof(Directions)).Cast<Directions>().Last();
            
            if (direction == lastDirection) {
                this.icon = "╮";
                this.direction--;
            } else {
                this.icon = "╯";
                this.direction++;
            }
 
        }

    }
}