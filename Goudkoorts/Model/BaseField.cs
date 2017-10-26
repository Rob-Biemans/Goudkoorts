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

        public abstract void PutMoveAbleObjectOnThisField(MoveAbleObject obj);

        public abstract void RemoveMoveAbleObjectFromThisField();

    }
}