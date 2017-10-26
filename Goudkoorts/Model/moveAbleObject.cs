using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts
{
    public abstract class MoveAbleObject : Field
    {
        public abstract bool Move();
    }
}