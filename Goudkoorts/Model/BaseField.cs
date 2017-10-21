using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public abstract class BaseField
    {
        virtual public BaseField NextField { get; set; }

        public abstract string Icon();

        public abstract void PutMoveAbleObjectOnThisField(Cart cart);

        public abstract void RemoveMoveAbleObjectFromThisField(Cart cart);

    }
}