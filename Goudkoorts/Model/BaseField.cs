using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public abstract class BaseField
    {
        virtual public BaseField NextField { get; set; }
        virtual public BaseField Next { get; set; }

        public abstract string Icon();
        public abstract int Pos { get; set; }

        public abstract bool PutMoveAbleObjectOnThisField(MoveAbleObject obj, Game game);

        public abstract void RemoveMoveAbleObjectFromThisField(bool val);

        public abstract bool ContainsMoveAbleObject();

        public abstract void Action(Game game);

    }
}