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

        public override void PutMoveAbleObjectOnThisField(MoveAbleObject obj)
        {

            if (this.direction == Directions.Up && this.Pos < obj.Pos)
            {
                this.MoveAbleObject = obj;
                this.MoveAbleObject.Pos = this.Pos;
            }

            if (this.direction == Directions.Down && this.Pos > obj.Pos)
            {
                this.MoveAbleObject = obj;
                this.MoveAbleObject.Pos = this.Pos;
            }

        }

        //public override void PutMoveAbleObjectOnThisField(MoveAbleObject obj)
        //{
        //    //Console.WriteLine("TEST");
        //    //Console.ReadKey();
        //}
    }
}